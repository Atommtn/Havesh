# apply-schema.ps1 - Apply EF migration SQL to Linux SQL Server
# Usage: .\apply-schema.ps1

$LIN = "Server=172.16.2.154,1433;User Id=sa;Password=2219@Atomtneda;TrustServerCertificate=True;"
$SCHEMA_FILE = "C:\Temp\havesh-schema.sql"

function Apply-Schema($connStr, $dbName) {
    Write-Host "`nApplying schema to $dbName ..." -ForegroundColor Cyan
    $sql = Get-Content $SCHEMA_FILE -Raw
    $batches = $sql -split '\r?\nGO\r?\n'

    $conn = New-Object System.Data.SqlClient.SqlConnection($connStr)
    $conn.Open()
    $ok = 0; $errs = 0

    foreach ($batch in $batches) {
        $b = $batch.Trim()
        if (-not $b) { continue }
        try {
            $cmd = New-Object System.Data.SqlClient.SqlCommand($b, $conn)
            $cmd.CommandTimeout = 120
            $cmd.ExecuteNonQuery() | Out-Null
            $ok++
        } catch {
            Write-Host "  ERR: $_" -ForegroundColor Red
            $errs++
        }
    }
    $conn.Close()
    Write-Host "  $dbName done: $ok ok, $errs errors" -ForegroundColor Green
}

Apply-Schema "${LIN}Database=HaveshAppDb;"     "HaveshAppDb"
Apply-Schema "${LIN}Database=HaveshPhase11Db;" "HaveshPhase11Db"

Write-Host "`nDone!" -ForegroundColor Green
