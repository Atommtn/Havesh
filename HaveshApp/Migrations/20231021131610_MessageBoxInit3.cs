using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HaveshApp.Migrations
{
    /// <inheritdoc />
    public partial class MessageBoxInit3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Header",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Messages",
                newName: "Command");

            migrationBuilder.AddColumn<int>(
                name: "Type",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Messages",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Messages");

            migrationBuilder.RenameColumn(
                name: "Command",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Messages",
                newName: "Header");
        }
    }
}
