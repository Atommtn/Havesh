using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HaveshApp.Migrations
{
    /// <inheritdoc />
    public partial class AddBranchToUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Users_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Users",
                column: "BranchFk");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_AppBranch_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Users",
                column: "BranchFk",
                principalSchema: "ShoukouhPardis12DBAdmin",
                principalTable: "AppBranch",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_AppBranch_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Users");
        }
    }
}
