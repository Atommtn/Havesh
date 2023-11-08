using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Havesh.Model.Migrations
{
    /// <inheritdoc />
    public partial class SessionActivity3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Icon",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_SessionActivity",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IconColor",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_SessionActivity",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IconName",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_SessionActivity",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IconSize",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_SessionActivity",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Icon",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_SessionActivity");

            migrationBuilder.DropColumn(
                name: "IconColor",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_SessionActivity");

            migrationBuilder.DropColumn(
                name: "IconName",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_SessionActivity");

            migrationBuilder.DropColumn(
                name: "IconSize",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_SessionActivity");
        }
    }
}
