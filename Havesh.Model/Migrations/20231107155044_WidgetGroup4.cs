using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Havesh.Model.Migrations
{
    /// <inheritdoc />
    public partial class WidgetGroup4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "WidgetId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Roles",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Roles_WidgetId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Roles",
                column: "WidgetId");

            migrationBuilder.AddForeignKey(
                name: "FK_Roles_Widgets_WidgetId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Roles",
                column: "WidgetId",
                principalSchema: "ShoukouhPardis12DBAdmin",
                principalTable: "Widgets",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Roles_Widgets_WidgetId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Roles");

            migrationBuilder.DropIndex(
                name: "IX_Roles_WidgetId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "WidgetId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Roles");
        }
    }
}
