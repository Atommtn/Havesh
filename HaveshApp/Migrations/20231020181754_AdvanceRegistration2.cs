using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HaveshApp.Migrations
{
    /// <inheritdoc />
    public partial class AdvanceRegistration2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "AdvanceRegistrations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateTime",
                schema: "ShoukouhPardis12DBAdmin",
                table: "AdvanceRegistrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateIndex(
                name: "IX_AdvanceRegistrations_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "AdvanceRegistrations",
                column: "BranchFk");

            migrationBuilder.AddForeignKey(
                name: "FK_AdvanceRegistrations_AppBranch_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "AdvanceRegistrations",
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
                name: "FK_AdvanceRegistrations_AppBranch_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "AdvanceRegistrations");

            migrationBuilder.DropIndex(
                name: "IX_AdvanceRegistrations_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "AdvanceRegistrations");

            migrationBuilder.DropColumn(
                name: "BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "AdvanceRegistrations");

            migrationBuilder.DropColumn(
                name: "DateTime",
                schema: "ShoukouhPardis12DBAdmin",
                table: "AdvanceRegistrations");
        }
    }
}
