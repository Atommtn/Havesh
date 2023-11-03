using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Havesh.Model.Migrations
{
    /// <inheritdoc />
    public partial class Dashboard2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "AllowHidden",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Widgets",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "AllowRemove",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Widgets",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AllowHidden",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Widgets");

            migrationBuilder.DropColumn(
                name: "AllowRemove",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Widgets");
        }
    }
}
