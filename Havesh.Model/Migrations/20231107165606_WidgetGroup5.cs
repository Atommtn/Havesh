using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Havesh.Model.Migrations
{
    /// <inheritdoc />
    public partial class WidgetGroup5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "BelongToRoles",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Widgets",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BelongToRoles",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Widgets");

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
    }
}
