using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HaveshApp.Migrations
{
    /// <inheritdoc />
    public partial class BranchCode_ParentBranchFk : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ParentBranch",
                schema: "ShoukouhPardis12DBAdmin",
                table: "AppBranch",
                newName: "ParentBranchFk");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ParentBranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "AppBranch",
                newName: "ParentBranch");
        }
    }
}
