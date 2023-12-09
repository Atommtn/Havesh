using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Havesh.Model.Migrations
{
    /// <inheritdoc />
    public partial class DashboardUser2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EntityChanges_Users_ActionById",
                schema: "ShoukouhPardis12DBAdmin",
                table: "EntityChanges");

            migrationBuilder.RenameColumn(
                name: "ActionById",
                schema: "ShoukouhPardis12DBAdmin",
                table: "EntityChanges",
                newName: "ActionByFk");

            migrationBuilder.RenameIndex(
                name: "IX_EntityChanges_ActionById",
                schema: "ShoukouhPardis12DBAdmin",
                table: "EntityChanges",
                newName: "IX_EntityChanges_ActionByFk");

            migrationBuilder.AddForeignKey(
                name: "FK_EntityChanges_Users_ActionByFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "EntityChanges",
                column: "ActionByFk",
                principalSchema: "ShoukouhPardis12DBAdmin",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EntityChanges_Users_ActionByFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "EntityChanges");

            migrationBuilder.RenameColumn(
                name: "ActionByFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "EntityChanges",
                newName: "ActionById");

            migrationBuilder.RenameIndex(
                name: "IX_EntityChanges_ActionByFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "EntityChanges",
                newName: "IX_EntityChanges_ActionById");

            migrationBuilder.AddForeignKey(
                name: "FK_EntityChanges_Users_ActionById",
                schema: "ShoukouhPardis12DBAdmin",
                table: "EntityChanges",
                column: "ActionById",
                principalSchema: "ShoukouhPardis12DBAdmin",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}
