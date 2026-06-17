# havesh-migrate.ps1
# Full migration: create DBs + apply schema + copy data + fix FK
# Usage: .\havesh-migrate.ps1

$WIN_STR    = "Server=172.16.2.254\sql2019;User Id=ShoukouhPardis12DBAdmin2;Password=ShoukouhPardis12DB@pass;TrustServerCertificate=True;"
$LIN_STR    = "Server=172.16.2.154,1433;User Id=sa;Password=2219@Atomtneda;TrustServerCertificate=True;"
$SCHEMA_SQL = "$PSScriptRoot\havesh-schema.sql"

$SKIP_TABLES = @(
    "__EFMigrationsHistory",
    "OrleansMembershipVersionTable",
    "OrleansMembershipTable",
    "OrleansGatewayTable",
    "OrleansRemindersTable",
    "OrleansStorage"
)

function Log  ($m) { Write-Host "`n[$( Get-Date -f HH:mm:ss )] $m" -ForegroundColor Cyan }
function Ok   ($m) { Write-Host "  OK   $m" -ForegroundColor Green }
function Warn ($m) { Write-Host "  --   $m" -ForegroundColor Yellow }
function Err  ($m) { Write-Host "  !!   $m" -ForegroundColor Red }

function Open-Conn($connStr) {
    $c = New-Object System.Data.SqlClient.SqlConnection($connStr)
    $c.Open()
    return $c
}

function Exec-Sql($connStr, $sql, $timeout = 120) {
    $c = Open-Conn $connStr
    try {
        $cmd = New-Object System.Data.SqlClient.SqlCommand($sql, $c)
        $cmd.CommandTimeout = $timeout
        $cmd.ExecuteNonQuery() | Out-Null
    } finally {
        $c.Close()
    }
}

function Query-Scalar($connStr, $sql) {
    $c = Open-Conn $connStr
    try {
        $cmd = New-Object System.Data.SqlClient.SqlCommand($sql, $c)
        $cmd.CommandTimeout = 60
        return $cmd.ExecuteScalar()
    } finally {
        $c.Close()
    }
}

# ── Step 1: Test connections ─────────────────────────────────────
Log "Step 1: Testing connections"

try { Exec-Sql "${WIN_STR}Database=master;" "SELECT 1"; Ok "Windows SQL connected" }
catch { Err "Cannot connect to Windows SQL: $_"; exit 1 }

try { Exec-Sql "${LIN_STR}Database=master;" "SELECT 1"; Ok "Linux SQL connected" }
catch { Err "Cannot connect to Linux SQL: $_"; exit 1 }

if (-not (Test-Path $SCHEMA_SQL)) {
    Err "Schema file not found: $SCHEMA_SQL"
    Write-Host "  Run first: dotnet ef migrations script --project Havesh.Model --startup-project HaveshApp --output havesh-schema.sql --idempotent" -ForegroundColor Yellow
    exit 1
}
Ok "Schema file found: $SCHEMA_SQL"

# ── Step 2: Create databases on Linux ───────────────────────────
Log "Step 2: Create databases on Linux"

foreach ($db in @("HaveshAppDb", "HaveshPhase11Db")) {
    $exists = Query-Scalar "${LIN_STR}Database=master;" "SELECT DB_ID('$db')"
    if ($exists -ne [DBNull]::Value -and $null -ne $exists) {
        Warn "$db already exists -- dropping and recreating"
        try {
            Exec-Sql "${LIN_STR}Database=master;" "ALTER DATABASE [$db] SET SINGLE_USER WITH ROLLBACK IMMEDIATE; DROP DATABASE [$db];"
        } catch { Warn "Drop failed (might be in use): $_" }
    }
    try {
        Exec-Sql "${LIN_STR}Database=master;" "CREATE DATABASE [$db];"
        Ok "Created $db"
    } catch { Err "Create $db failed: $_"; exit 1 }
}

# ── Step 3: Apply EF schema to both databases ────────────────────
Log "Step 3: Applying EF schema"

$rawSql = Get-Content $SCHEMA_SQL -Raw
$batches = $rawSql -split '\r?\nGO\r?\n'

function Apply-Schema($db) {
    Write-Host "  Applying schema to $db ..."
    $ok = 0; $errs = 0
    foreach ($batch in $batches) {
        $b = $batch.Trim()
        if (-not $b) { continue }
        try {
            Exec-Sql "${LIN_STR}Database=$db;" $b 120
            $ok++
        } catch {
            Err "Schema batch error in ${db}: $_"
            $errs++
        }
    }
    Ok "$db schema: $ok batches ok, $errs errors"
}

Apply-Schema "HaveshAppDb"
Apply-Schema "HaveshPhase11Db"

# ── Step 4: Copy data ────────────────────────────────────────────
function Migrate-Db($srcDb, $dstDb) {
    Log "Step 4: Migrating $srcDb --> $dstDb"

    # Get source table list
    $wc = Open-Conn "${WIN_STR}Database=$srcDb;"
    $cmd = New-Object System.Data.SqlClient.SqlCommand(
        "SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE='BASE TABLE' ORDER BY TABLE_NAME",
        $wc)
    $r = $cmd.ExecuteReader()
    $tables = @()
    while ($r.Read()) { $tables += $r.GetString(0) }
    $r.Close(); $wc.Close()
    Write-Host "  Tables found: $($tables.Count)"

    # Disable FK constraints
    Write-Host "  Disabling FK constraints on Linux..."
    try {
        Exec-Sql "${LIN_STR}Database=$dstDb;" @"
DECLARE @s NVARCHAR(MAX)='';
SELECT @s+='ALTER TABLE [dbo].['+OBJECT_NAME(parent_object_id)+'] NOCHECK CONSTRAINT ['+name+'];'
FROM sys.foreign_keys WHERE SCHEMA_NAME(schema_id)='dbo';
EXEC sp_executesql @s;
"@ 120
        Ok "FKs disabled"
    } catch { Warn "FK disable: $_" }

    $ok = 0; $errs = 0; $skip = 0

    foreach ($t in $tables) {
        if ($SKIP_TABLES -contains $t) { Warn "SKIP  $t"; $skip++; continue }

        try {
            # Clear destination (ignore errors for empty tables)
            try { Exec-Sql "${LIN_STR}Database=$dstDb;" "DELETE FROM [dbo].[$t]" 60 } catch {}

            # Read source
            $src = Open-Conn "${WIN_STR}Database=$srcDb;"
            $srcCmd = New-Object System.Data.SqlClient.SqlCommand("SELECT * FROM [dbo].[$t]", $src)
            $srcCmd.CommandTimeout = 300
            $rdr = $srcCmd.ExecuteReader()

            # Bulk copy -- NEW connection per table (key fix)
            $bulk = New-Object System.Data.SqlClient.SqlBulkCopy(
                "${LIN_STR}Database=$dstDb;",
                [System.Data.SqlClient.SqlBulkCopyOptions]::KeepIdentity)
            $bulk.DestinationTableName = "[dbo].[$t]"
            $bulk.BulkCopyTimeout = 300
            $bulk.WriteToServer($rdr)
            $rdr.Close(); $src.Close()
            $bulk.Close()

            $cnt = Query-Scalar "${LIN_STR}Database=$dstDb;" "SELECT COUNT(*) FROM [dbo].[$t]"
            Ok "COPY  $t  ($cnt rows)"
            $ok++
        } catch {
            Err "FAIL  $t  --> $_"
            $errs++
        }
    }

    # Re-enable FK constraints
    Write-Host "  Re-enabling FK constraints..."
    try {
        Exec-Sql "${LIN_STR}Database=$dstDb;" @"
DECLARE @s NVARCHAR(MAX)='';
SELECT @s+='ALTER TABLE [dbo].['+OBJECT_NAME(parent_object_id)+'] WITH CHECK CHECK CONSTRAINT ['+name+'];'
FROM sys.foreign_keys WHERE SCHEMA_NAME(schema_id)='dbo';
EXEC sp_executesql @s;
"@ 120
        Ok "FKs re-enabled"
    } catch { Warn "FK re-enable: $_" }

    Write-Host "  Result: $ok copied, $errs errors, $skip skipped"
}

Migrate-Db "HaveshAppDb"     "HaveshAppDb"
Migrate-Db "HaveshPhase11Db" "HaveshPhase11Db"

# ── Step 5: Fix wrong FK ─────────────────────────────────────────
Log "Step 5: Fix wrong FK in HaveshAppDb"
try {
    Exec-Sql "${LIN_STR}Database=HaveshAppDb;" @"
IF EXISTS (SELECT 1 FROM sys.foreign_keys WHERE name='FK_ShokouhPardis_StudentSessionActivity_ShokouhPardis_TimeTableSession_TimeTableFk')
BEGIN
    ALTER TABLE ShokouhPardis_StudentSessionActivity
        DROP CONSTRAINT FK_ShokouhPardis_StudentSessionActivity_ShokouhPardis_TimeTableSession_TimeTableFk;
    ALTER TABLE ShokouhPardis_StudentSessionActivity
        ADD CONSTRAINT FK_ShokouhPardis_StudentSessionActivity_ShokouhPardis_TimeTable_TimeTableFk
        FOREIGN KEY (TimeTableFk) REFERENCES ShokouhPardis_TimeTable(Id);
    PRINT 'FK fixed'
END
ELSE
    PRINT 'FK already correct or not found'
"@ 60
    Ok "FK fixed"
} catch { Err "FK fix: $_" }

# ── Done ─────────────────────────────────────────────────────────
Log "Migration complete!"
Write-Host "  Next: restart containers on Linux:" -ForegroundColor Green
Write-Host "    ./deploy.sh down all && ./deploy.sh up all" -ForegroundColor Green
