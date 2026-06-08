#!/bin/bash
# deploy.sh - مدیریت deploy هر دو شعبه هاوش
#
# ساختار:
#   havesh-sqlserver          ← SQL Server مشترک
#   havesh-silo-SHPB          ← Orleans Silo شعبه آکادمی
#   havesh-app-SHPB           ← App شعبه آکادمی  (پورت 8080)
#   havesh-silo-PH11          ← Orleans Silo شعبه فاز ۱۱
#   havesh-app-PH11           ← App شعبه فاز ۱۱  (پورت 8090)

set -e
SCRIPT_DIR="$(cd "$(dirname "${BASH_SOURCE[0]}")" && pwd)"

# ===== رنگ‌بندی خروجی =====
RED='\033[0;31m'
GREEN='\033[0;32m'
YELLOW='\033[1;33m'
BLUE='\033[0;34m'
NC='\033[0m'

log()    { echo -e "${GREEN}[✓]${NC} $1"; }
warn()   { echo -e "${YELLOW}[!]${NC} $1"; }
error()  { echo -e "${RED}[✗]${NC} $1"; exit 1; }
header() { echo -e "\n${BLUE}========================================${NC}"; echo -e "${BLUE}  $1${NC}"; echo -e "${BLUE}========================================${NC}"; }

usage() {
    echo ""
    echo "استفاده: ./deploy.sh [دستور] [شعبه]"
    echo ""
    echo "دستورها:"
    echo "  sql-up      راه‌اندازی SQL Server مشترک"
    echo "  sql-down    خاموش کردن SQL Server"
    echo "  up          راه‌اندازی شعبه"
    echo "  down        خاموش کردن شعبه"
    echo "  build       build ایمیج‌ها"
    echo "  restart     ری‌استارت شعبه"
    echo "  logs        نمایش لاگ‌ها"
    echo "  ps          وضعیت همه کانتینرها"
    echo "  migrate     انتقال دیتابیس از سرور فیزیکی"
    echo ""
    echo "شعبه‌ها:"
    echo "  shpb        آکادمی هاوِش  (پورت 8080)"
    echo "  ph11        فاز ۱۱        (پورت 8090)"
    echo "  all         هر دو شعبه"
    echo ""
    echo "مثال‌ها:"
    echo "  ./deploy.sh sql-up                  ← اول SQL را بالا بیاور"
    echo "  ./deploy.sh up all                  ← هر دو شعبه"
    echo "  ./deploy.sh build all && ./deploy.sh up all"
    echo "  ./deploy.sh logs shpb"
    echo "  ./deploy.sh ps"
    echo ""
}

# ===== SQL Server مشترک =====
sql_up() {
    header "راه‌اندازی SQL Server مشترک"
    docker compose \
        -f "$SCRIPT_DIR/docker-compose.sqlserver.yml" \
        -p "havesh-sql" \
        up -d
    log "SQL Server در حال راه‌اندازی... (ممکن است 30 ثانیه طول بکشد)"
}

sql_down() {
    header "خاموش کردن SQL Server"
    warn "این کار SQL Server را برای هر دو شعبه خاموش می‌کند!"
    read -p "ادامه می‌دهید؟ (y/N): " confirm
    [[ "$confirm" == "y" || "$confirm" == "Y" ]] || { warn "لغو شد."; exit 0; }
    docker compose \
        -f "$SCRIPT_DIR/docker-compose.sqlserver.yml" \
        -p "havesh-sql" \
        down
}

# ===== شعبه‌ها =====
get_env_file() {
    case $1 in
        shpb) echo "$SCRIPT_DIR/shpb.env" ;;
        ph11) echo "$SCRIPT_DIR/ph11.env" ;;
        *) error "شعبه نامعتبر: $1" ;;
    esac
}

run_branch() {
    local cmd=$1
    local branch=$2
    local env_file=$(get_env_file "$branch")

    [[ -f "$env_file" ]] || error "فایل env پیدا نشد: $env_file"

    header "شعبه $(echo $branch | tr '[:lower:]' '[:upper:]') | $cmd"

    ENV_FILE="$env_file" \
    docker compose \
        -f "$SCRIPT_DIR/docker-compose.branch.yml" \
        -p "havesh-$branch" \
        --env-file "$env_file" \
        $cmd
}

execute() {
    local cmd=$1
    local branch=$2

    case $branch in
        shpb|ph11)
            run_branch "$cmd" "$branch"
            ;;
        all)
            run_branch "$cmd" "shpb"
            run_branch "$cmd" "ph11"
            ;;
        "")
            error "شعبه را مشخص کنید (shpb / ph11 / all)"
            ;;
        *)
            error "شعبه نامعتبر: $branch"
            ;;
    esac
}

# ===== main =====
CMD=${1:-""}
BRANCH=${2:-""}

case $CMD in
    sql-up)   sql_up ;;
    sql-down) sql_down ;;
    up)       execute "up -d" "$BRANCH" ;;
    down)     execute "down" "$BRANCH" ;;
    build)    execute "build" "$BRANCH" ;;
    restart)  execute "restart" "$BRANCH" ;;
    logs)     execute "logs -f" "$BRANCH" ;;
    ps)
        header "وضعیت همه کانتینرهای هاوش"
        docker ps --filter "name=havesh" --format "table {{.Names}}\t{{.Status}}\t{{.Ports}}"
        ;;
    migrate)
        bash "$SCRIPT_DIR/migrate-db.sh"
        ;;
    *)
        usage
        ;;
esac
