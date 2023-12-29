using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Havesh.Model.Migrations
{
    /// <inheritdoc />
    public partial class DashboardUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dashboards_Users_UserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Dashboards");

            migrationBuilder.RenameColumn(
                name: "UserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Dashboards",
                newName: "UserFk");

            migrationBuilder.RenameIndex(
                name: "IX_Dashboards_UserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Dashboards",
                newName: "IX_Dashboards_UserFk");

            migrationBuilder.AddForeignKey(
                name: "FK_Dashboards_Users_UserFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Dashboards",
                column: "UserFk",
                principalSchema: "ShoukouhPardis12DBAdmin",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dashboards_Users_UserFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Dashboards");

            migrationBuilder.RenameColumn(
                name: "UserFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Dashboards",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Dashboards_UserFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Dashboards",
                newName: "IX_Dashboards_UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Dashboards_Users_UserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Dashboards",
                column: "UserId",
                principalSchema: "ShoukouhPardis12DBAdmin",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
