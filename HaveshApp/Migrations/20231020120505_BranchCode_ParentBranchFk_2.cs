using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HaveshApp.Migrations
{
    /// <inheritdoc />
    public partial class BranchCode_ParentBranchFk_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_AppBranch_ParentBranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "AppBranch",
                column: "ParentBranchFk");

            migrationBuilder.AddForeignKey(
                name: "FK_AppBranch_AppBranch_ParentBranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "AppBranch",
                column: "ParentBranchFk",
                principalSchema: "ShoukouhPardis12DBAdmin",
                principalTable: "AppBranch",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppBranch_AppBranch_ParentBranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "AppBranch");

            migrationBuilder.DropIndex(
                name: "IX_AppBranch_ParentBranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "AppBranch");
        }
    }
}
