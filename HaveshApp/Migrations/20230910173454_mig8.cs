using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShokouhApp.Migrations
{
    public partial class mig8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ShowByValue",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_SessionActivityValueOption",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ShowByValue",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_SessionActivityValueOption");
        }
    }
}
