#!/bin/bash
# migrate-db.sh
# انتقال دیتابیس از سرور فیزیکی 172.16.1.140 به Docker SQL Server
#
# پیش‌نیاز: sqlcmd روی این سرور نصب باشد
# نصب: https://learn.microsoft.com/en-us/sql/tools/sqlcmd/sqlcmd-utility

set -e

SCRIPT_DIR="$(cd "$(dirname "${BASH_SOURCE[0]}")" && pwd)"
BACKUP_DIR="$SCRIPT_DIR/db-backups"
mkdir -p "$BACKUP_DIR"

# ===== تنظیمات سرور مبدا (سرور فیزیکی شما) =====
SRC_SERVER="172.16.1.140\\sql2019"
SRC_SA_USER="sa"
SRC_SA_PASS="Atomtneda"
SRC_SHPB_USER="ShoukouhPardis12DBAdmin2"
SRC_SHPB_PASS="ShoukouhPardis12DB@pass"

# ===== تنظیمات سرور مقصد (Docker) =====
DST_SERVER="localhost,1433"
DST_SA_USER="sa"
DST_SA_PASS="Atomtneda"

# دیتابیس‌هایی که باید منتقل شوند
declare -A DB_USERS=(
  ["HaveshAppDb"]="$SRC_SHPB_USER|$SRC_SHPB_PASS"
  ["HaveshPhase11Db"]="$SRC_SA_USER|$SRC_SA_PASS"
  ["HaveshGrains"]="$SRC_SHPB_USER|$SRC_SHPB_PASS"
)

echo "================================================"
echo "   انتقال دیتابیس از سرور فیزیکی به Docker"
echo "================================================"
echo ""
echo "مبدا:  $SRC_SERVER"
echo "مقصد:  $DST_SERVER (Docker)"
echo ""

# بررسی اینکه Docker SQL Server آماده است
echo ">>> بررسی اتصال به Docker SQL Server..."
if ! sqlcmd -S "$DST_SERVER" -U "$DST_SA_USER" -P "$DST_SA_PASS" -Q "SELECT 1" -C 2>/dev/null; then
  echo "خطا: Docker SQL Server در دسترس نیست. ابتدا اجرا کنید: ./deploy.sh sql-up"
  exit 1
fi
echo "اتصال به Docker SQL Server برقرار شد."
echo ""

backup_and_restore() {
  local DB=$1
  local SRC_USER=$2
  local SRC_PASS=$3

  echo "-------------------------------------------"
  echo "دیتابیس: $DB"
  echo "-------------------------------------------"

  # مسیر backup روی سرور مبدا (باید سرور فیزیکی دسترسی write داشته باشد)
  local REMOTE_BACKUP_PATH="C:\\Temp\\${DB}_backup.bak"
  local LOCAL_BACKUP="$BACKUP_DIR/${DB}_backup.bak"

  # ۱. گرفتن backup از سرور مبدا
  echo "  ۱. گرفتن backup از سرور مبدا..."
  sqlcmd -S "$SRC_SERVER" -U "$SRC_USER" -P "$SRC_PASS" -C -Q "
    BACKUP DATABASE [$DB]
    TO DISK = N'$REMOTE_BACKUP_PATH'
    WITH FORMAT, INIT, COMPRESSION, STATS = 10;
  "

  # ۲. کپی فایل backup به این سرور
  echo "  ۲. کپی فایل backup..."
  echo "  (اگر سرور فیزیکی Windows است این دستور را اجرا کنید:)"
  echo "  scp user@172.16.1.140:C:/Temp/${DB}_backup.bak $LOCAL_BACKUP"
  echo ""
  read -p "  بعد از کپی Enter بزنید..." dummy

  # ۳. کپی backup به داخل کانتینر Docker
  echo "  ۳. کپی به داخل Docker..."
  docker cp "$LOCAL_BACKUP" havesh-sqlserver:/var/opt/mssql/backup/${DB}.bak

  # ۴. Restore در Docker SQL Server
  echo "  ۴. Restore در Docker SQL Server..."
  sqlcmd -S "$DST_SERVER" -U "$DST_SA_USER" -P "$DST_SA_PASS" -C -Q "
    -- ساخت دایرکتوری backup اگر وجود ندارد
    EXEC xp_create_subdir '/var/opt/mssql/backup';

    RESTORE DATABASE [$DB]
    FROM DISK = '/var/opt/mssql/backup/${DB}.bak'
    WITH REPLACE,
         MOVE '${DB}' TO '/var/opt/mssql/data/${DB}.mdf',
         MOVE '${DB}_log' TO '/var/opt/mssql/data/${DB}_log.ldf',
         STATS = 10;
  "

  echo "  ✓ دیتابیس $DB با موفقیت منتقل شد."
  echo ""
}

# ساخت دایرکتوری backup در Docker
docker exec havesh-sqlserver mkdir -p /var/opt/mssql/backup

# ساخت یوزرها در Docker SQL Server
echo ">>> ساخت یوزرها در Docker SQL Server..."
sqlcmd -S "$DST_SERVER" -U "$DST_SA_USER" -P "$DST_SA_PASS" -C -Q "
  IF NOT EXISTS (SELECT * FROM sys.server_principals WHERE name = 'ShoukouhPardis12DBAdmin2')
  BEGIN
    CREATE LOGIN [ShoukouhPardis12DBAdmin2]
    WITH PASSWORD = 'ShoukouhPardis12DB@pass';
    PRINT 'Login ShoukouhPardis12DBAdmin2 created.';
  END
"
echo ""

# انتقال هر دیتابیس
for DB in "${!DB_USERS[@]}"; do
  IFS='|' read -r USER PASS <<< "${DB_USERS[$DB]}"
  backup_and_restore "$DB" "$USER" "$PASS"
done

# تنظیم دسترسی‌های یوزرها روی دیتابیس‌های منتقل شده
echo ">>> تنظیم دسترسی‌های یوزرها..."
sqlcmd -S "$DST_SERVER" -U "$DST_SA_USER" -P "$DST_SA_PASS" -C -Q "
  USE [HaveshAppDb];
  IF NOT EXISTS (SELECT * FROM sys.database_principals WHERE name = 'ShoukouhPardis12DBAdmin2')
    CREATE USER [ShoukouhPardis12DBAdmin2] FOR LOGIN [ShoukouhPardis12DBAdmin2];
  ALTER ROLE db_owner ADD MEMBER [ShoukouhPardis12DBAdmin2];

  USE [HaveshGrains];
  IF NOT EXISTS (SELECT * FROM sys.database_principals WHERE name = 'ShoukouhPardis12DBAdmin2')
    CREATE USER [ShoukouhPardis12DBAdmin2] FOR LOGIN [ShoukouhPardis12DBAdmin2];
  ALTER ROLE db_owner ADD MEMBER [ShoukouhPardis12DBAdmin2];
"

echo "================================================"
echo "   انتقال دیتابیس‌ها کامل شد!"
echo "================================================"
echo ""
echo "حالا می‌توانید شعبه‌ها را راه‌اندازی کنید:"
echo "  ./deploy.sh up shpb"
echo "  ./deploy.sh up ph11"
