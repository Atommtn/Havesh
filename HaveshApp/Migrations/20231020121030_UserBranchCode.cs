using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HaveshApp.Migrations
{
    /// <inheritdoc />
    public partial class UserBranchCode : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BCode",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "Gender",
                schema: "dbo",
                table: "ShokouhPardis_StudentClass",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BCode",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Gender",
                schema: "dbo",
                table: "ShokouhPardis_StudentClass");
        }
    }
}
