$WIN = "Server=172.16.2.254\sql2019;User Id=ShoukouhPardis12DBAdmin2;Password=ShoukouhPardis12DB@pass;TrustServerCertificate=True;"
$LIN = "Server=172.16.2.154,1433;User Id=sa;Password=2219@Atomtneda;TrustServerCertificate=True;"

$wc = New-Object System.Data.SqlClient.SqlConnection("${WIN}Database=HaveshAppDb;")
$wc.Open()
$cmd = New-Object System.Data.SqlClient.SqlCommand(
    "SELECT TABLE_NAME, (SELECT COUNT(*) FROM [dbo].[\" + '] + TABLE_NAME + ["\]) AS cnt FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE='BASE TABLE' ORDER BY TABLE_NAME", $wc)

# ساده‌تر:
$tables = @()
$r = (New-Object System.Data.SqlClient.SqlCommand("SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE='BASE TABLE' ORDER BY TABLE_NAME", $wc)).ExecuteReader()
while ($r.Read()) { $tables += $r.GetString(0) }
$r.Close()

$lc = New-Object System.Data.SqlClient.SqlConnection("${LIN}Database=HaveshAppDb;")
$lc.Open()

$missing = @()
foreach ($t in $tables) {
    $wn = (New-Object System.Data.SqlClient.SqlCommand("SELECT COUNT(*) FROM [dbo].[$t]", $wc)).ExecuteScalar()
    $ln = (New-Object System.Data.SqlClient.SqlCommand("SELECT COUNT(*) FROM [dbo].[$t]", $lc)).ExecuteScalar()
    if ($wn -gt 0 -and $ln -eq 0) {
        Write-Host "MISSING: $t (Win=$wn, Lin=$ln)" -ForegroundColor Red
        $missing += $t
    }
}
$wc.Close(); $lc.Close()
Write-Host "`nTotal missing: $($missing.Count) tables"