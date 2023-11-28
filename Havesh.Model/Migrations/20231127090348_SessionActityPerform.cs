using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Havesh.Model.Migrations
{
    /// <inheritdoc />
    public partial class SessionActityPerform : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDefault",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_SessionActivity",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "BCode",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_LessonPlanSectionItem",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_LessonPlanSectionItem",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_LessonPlanSectionItem",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_LessonPlanSectionItem",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "Guid",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_LessonPlanSectionItem",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_LessonPlanSectionItem",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_LessonPlanSectionItem",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_LessonPlanSectionItem",
                type: "datetime2",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ShokouhPardis_LessonPlanSectionItem_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_LessonPlanSectionItem",
                column: "BranchFk");

            migrationBuilder.AddForeignKey(
                name: "FK_ShokouhPardis_LessonPlanSectionItem_AppBranch_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_LessonPlanSectionItem",
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
                name: "FK_ShokouhPardis_LessonPlanSectionItem_AppBranch_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_LessonPlanSectionItem");

            migrationBuilder.DropIndex(
                name: "IX_ShokouhPardis_LessonPlanSectionItem_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_LessonPlanSectionItem");

            migrationBuilder.DropColumn(
                name: "IsDefault",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_SessionActivity");

            migrationBuilder.DropColumn(
                name: "BCode",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_LessonPlanSectionItem");

            migrationBuilder.DropColumn(
                name: "BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_LessonPlanSectionItem");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_LessonPlanSectionItem");

            migrationBuilder.DropColumn(
                name: "CreatedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_LessonPlanSectionItem");

            migrationBuilder.DropColumn(
                name: "Guid",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_LessonPlanSectionItem");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_LessonPlanSectionItem");

            migrationBuilder.DropColumn(
                name: "ModifiedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_LessonPlanSectionItem");

            migrationBuilder.DropColumn(
                name: "ModifiedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_LessonPlanSectionItem");
        }
    }
}
