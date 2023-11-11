using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Havesh.Model.Migrations
{
    /// <inheritdoc />
    public partial class FixIds_1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ID",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TimeTableSession",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "TermSessionTemplateDateID",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TermSessionTemplateDate",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "TermSessionTemplateID",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TermSessionTemplate",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "StudentSessionActivityID",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_StudentSessionActivity",
                newName: "Id");

            migrationBuilder.AddColumn<string>(
                name: "BCode",
                schema: "dbo",
                table: "ShokouhPardis_YearClass",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BranchFk",
                schema: "dbo",
                table: "ShokouhPardis_YearClass",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "BCode",
                schema: "dbo",
                table: "ShokouhPardis_WeekDay",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BranchFk",
                schema: "dbo",
                table: "ShokouhPardis_WeekDay",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "BCode",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_SessionActivityValueOption",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_SessionActivityValueOption",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "BCode",
                schema: "dbo",
                table: "ShokouhPardis_Program",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BranchFk",
                schema: "dbo",
                table: "ShokouhPardis_Program",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "BCode",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Roles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Roles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "BCode",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Permissions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Permissions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "BCode",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Messages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Messages",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "BCode",
                schema: "ShoukouhPardis12DBAdmin",
                table: "MessageBoxes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "MessageBoxes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "BCode",
                schema: "ShoukouhPardis12DBAdmin",
                table: "MessageActions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "MessageActions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "BCode",
                schema: "ShoukouhPardis12DBAdmin",
                table: "MessageActionOptions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "MessageActionOptions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "BCode",
                schema: "ShoukouhPardis12DBAdmin",
                table: "AdvanceRegistrations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ShokouhPardis_YearClass_BranchFk",
                schema: "dbo",
                table: "ShokouhPardis_YearClass",
                column: "BranchFk");

            migrationBuilder.CreateIndex(
                name: "IX_ShokouhPardis_WeekDay_BranchFk",
                schema: "dbo",
                table: "ShokouhPardis_WeekDay",
                column: "BranchFk");

            migrationBuilder.CreateIndex(
                name: "IX_ShokouhPardis_SessionActivityValueOption_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_SessionActivityValueOption",
                column: "BranchFk");

            migrationBuilder.CreateIndex(
                name: "IX_ShokouhPardis_Program_BranchFk",
                schema: "dbo",
                table: "ShokouhPardis_Program",
                column: "BranchFk");

            migrationBuilder.CreateIndex(
                name: "IX_Roles_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Roles",
                column: "BranchFk");

            migrationBuilder.CreateIndex(
                name: "IX_Permissions_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Permissions",
                column: "BranchFk");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Messages",
                column: "BranchFk");

            migrationBuilder.CreateIndex(
                name: "IX_MessageBoxes_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "MessageBoxes",
                column: "BranchFk");

            migrationBuilder.CreateIndex(
                name: "IX_MessageActions_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "MessageActions",
                column: "BranchFk");

            migrationBuilder.CreateIndex(
                name: "IX_MessageActionOptions_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "MessageActionOptions",
                column: "BranchFk");

            migrationBuilder.AddForeignKey(
                name: "FK_MessageActionOptions_AppBranch_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "MessageActionOptions",
                column: "BranchFk",
                principalSchema: "ShoukouhPardis12DBAdmin",
                principalTable: "AppBranch",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_MessageActions_AppBranch_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "MessageActions",
                column: "BranchFk",
                principalSchema: "ShoukouhPardis12DBAdmin",
                principalTable: "AppBranch",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_MessageBoxes_AppBranch_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "MessageBoxes",
                column: "BranchFk",
                principalSchema: "ShoukouhPardis12DBAdmin",
                principalTable: "AppBranch",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_AppBranch_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Messages",
                column: "BranchFk",
                principalSchema: "ShoukouhPardis12DBAdmin",
                principalTable: "AppBranch",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Permissions_AppBranch_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Permissions",
                column: "BranchFk",
                principalSchema: "ShoukouhPardis12DBAdmin",
                principalTable: "AppBranch",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Roles_AppBranch_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Roles",
                column: "BranchFk",
                principalSchema: "ShoukouhPardis12DBAdmin",
                principalTable: "AppBranch",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_ShokouhPardis_Program_AppBranch_BranchFk",
                schema: "dbo",
                table: "ShokouhPardis_Program",
                column: "BranchFk",
                principalSchema: "ShoukouhPardis12DBAdmin",
                principalTable: "AppBranch",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_ShokouhPardis_SessionActivityValueOption_AppBranch_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_SessionActivityValueOption",
                column: "BranchFk",
                principalSchema: "ShoukouhPardis12DBAdmin",
                principalTable: "AppBranch",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_ShokouhPardis_WeekDay_AppBranch_BranchFk",
                schema: "dbo",
                table: "ShokouhPardis_WeekDay",
                column: "BranchFk",
                principalSchema: "ShoukouhPardis12DBAdmin",
                principalTable: "AppBranch",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_ShokouhPardis_YearClass_AppBranch_BranchFk",
                schema: "dbo",
                table: "ShokouhPardis_YearClass",
                column: "BranchFk",
                principalSchema: "ShoukouhPardis12DBAdmin",
                principalTable: "AppBranch",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MessageActionOptions_AppBranch_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "MessageActionOptions");

            migrationBuilder.DropForeignKey(
                name: "FK_MessageActions_AppBranch_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "MessageActions");

            migrationBuilder.DropForeignKey(
                name: "FK_MessageBoxes_AppBranch_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "MessageBoxes");

            migrationBuilder.DropForeignKey(
                name: "FK_Messages_AppBranch_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Messages");

            migrationBuilder.DropForeignKey(
                name: "FK_Permissions_AppBranch_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Permissions");

            migrationBuilder.DropForeignKey(
                name: "FK_Roles_AppBranch_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Roles");

            migrationBuilder.DropForeignKey(
                name: "FK_ShokouhPardis_Program_AppBranch_BranchFk",
                schema: "dbo",
                table: "ShokouhPardis_Program");

            migrationBuilder.DropForeignKey(
                name: "FK_ShokouhPardis_SessionActivityValueOption_AppBranch_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_SessionActivityValueOption");

            migrationBuilder.DropForeignKey(
                name: "FK_ShokouhPardis_WeekDay_AppBranch_BranchFk",
                schema: "dbo",
                table: "ShokouhPardis_WeekDay");

            migrationBuilder.DropForeignKey(
                name: "FK_ShokouhPardis_YearClass_AppBranch_BranchFk",
                schema: "dbo",
                table: "ShokouhPardis_YearClass");

            migrationBuilder.DropIndex(
                name: "IX_ShokouhPardis_YearClass_BranchFk",
                schema: "dbo",
                table: "ShokouhPardis_YearClass");

            migrationBuilder.DropIndex(
                name: "IX_ShokouhPardis_WeekDay_BranchFk",
                schema: "dbo",
                table: "ShokouhPardis_WeekDay");

            migrationBuilder.DropIndex(
                name: "IX_ShokouhPardis_SessionActivityValueOption_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_SessionActivityValueOption");

            migrationBuilder.DropIndex(
                name: "IX_ShokouhPardis_Program_BranchFk",
                schema: "dbo",
                table: "ShokouhPardis_Program");

            migrationBuilder.DropIndex(
                name: "IX_Roles_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Roles");

            migrationBuilder.DropIndex(
                name: "IX_Permissions_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Permissions");

            migrationBuilder.DropIndex(
                name: "IX_Messages_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Messages");

            migrationBuilder.DropIndex(
                name: "IX_MessageBoxes_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "MessageBoxes");

            migrationBuilder.DropIndex(
                name: "IX_MessageActions_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "MessageActions");

            migrationBuilder.DropIndex(
                name: "IX_MessageActionOptions_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "MessageActionOptions");

            migrationBuilder.DropColumn(
                name: "BCode",
                schema: "dbo",
                table: "ShokouhPardis_YearClass");

            migrationBuilder.DropColumn(
                name: "BranchFk",
                schema: "dbo",
                table: "ShokouhPardis_YearClass");

            migrationBuilder.DropColumn(
                name: "BCode",
                schema: "dbo",
                table: "ShokouhPardis_WeekDay");

            migrationBuilder.DropColumn(
                name: "BranchFk",
                schema: "dbo",
                table: "ShokouhPardis_WeekDay");

            migrationBuilder.DropColumn(
                name: "BCode",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_SessionActivityValueOption");

            migrationBuilder.DropColumn(
                name: "BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_SessionActivityValueOption");

            migrationBuilder.DropColumn(
                name: "BCode",
                schema: "dbo",
                table: "ShokouhPardis_Program");

            migrationBuilder.DropColumn(
                name: "BranchFk",
                schema: "dbo",
                table: "ShokouhPardis_Program");

            migrationBuilder.DropColumn(
                name: "BCode",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "BCode",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Permissions");

            migrationBuilder.DropColumn(
                name: "BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Permissions");

            migrationBuilder.DropColumn(
                name: "BCode",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "BCode",
                schema: "ShoukouhPardis12DBAdmin",
                table: "MessageBoxes");

            migrationBuilder.DropColumn(
                name: "BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "MessageBoxes");

            migrationBuilder.DropColumn(
                name: "BCode",
                schema: "ShoukouhPardis12DBAdmin",
                table: "MessageActions");

            migrationBuilder.DropColumn(
                name: "BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "MessageActions");

            migrationBuilder.DropColumn(
                name: "BCode",
                schema: "ShoukouhPardis12DBAdmin",
                table: "MessageActionOptions");

            migrationBuilder.DropColumn(
                name: "BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "MessageActionOptions");

            migrationBuilder.DropColumn(
                name: "BCode",
                schema: "ShoukouhPardis12DBAdmin",
                table: "AdvanceRegistrations");

            migrationBuilder.RenameColumn(
                name: "Id",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TimeTableSession",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Id",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TermSessionTemplateDate",
                newName: "TermSessionTemplateDateID");

            migrationBuilder.RenameColumn(
                name: "Id",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TermSessionTemplate",
                newName: "TermSessionTemplateID");

            migrationBuilder.RenameColumn(
                name: "Id",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_StudentSessionActivity",
                newName: "StudentSessionActivityID");
        }
    }
}
