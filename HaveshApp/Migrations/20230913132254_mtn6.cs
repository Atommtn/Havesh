using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HaveshApp.Migrations
{
    public partial class mtn6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsPreRegister",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_DailyJV",
                type: "bit",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsPreRegister",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_DailyJV");
        }
    }
}
