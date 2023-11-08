using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Havesh.Model.Migrations
{
    /// <inheritdoc />
    public partial class WidgetGroup2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BelongToRoleId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "WidgetGroup",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DashboardTemplateId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "WidgetGroup",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Icon",
                schema: "ShoukouhPardis12DBAdmin",
                table: "WidgetGroup",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "IconColor",
                schema: "ShoukouhPardis12DBAdmin",
                table: "WidgetGroup",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "IconName",
                schema: "ShoukouhPardis12DBAdmin",
                table: "WidgetGroup",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "IconSize",
                schema: "ShoukouhPardis12DBAdmin",
                table: "WidgetGroup",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_WidgetGroup_BelongToRoleId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "WidgetGroup",
                column: "BelongToRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_WidgetGroup_DashboardTemplateId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "WidgetGroup",
                column: "DashboardTemplateId");

            migrationBuilder.AddForeignKey(
                name: "FK_WidgetGroup_DashboardTemplates_DashboardTemplateId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "WidgetGroup",
                column: "DashboardTemplateId",
                principalSchema: "ShoukouhPardis12DBAdmin",
                principalTable: "DashboardTemplates",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_WidgetGroup_Roles_BelongToRoleId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "WidgetGroup",
                column: "BelongToRoleId",
                principalSchema: "ShoukouhPardis12DBAdmin",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WidgetGroup_DashboardTemplates_DashboardTemplateId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "WidgetGroup");

            migrationBuilder.DropForeignKey(
                name: "FK_WidgetGroup_Roles_BelongToRoleId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "WidgetGroup");

            migrationBuilder.DropIndex(
                name: "IX_WidgetGroup_BelongToRoleId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "WidgetGroup");

            migrationBuilder.DropIndex(
                name: "IX_WidgetGroup_DashboardTemplateId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "WidgetGroup");

            migrationBuilder.DropColumn(
                name: "BelongToRoleId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "WidgetGroup");

            migrationBuilder.DropColumn(
                name: "DashboardTemplateId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "WidgetGroup");

            migrationBuilder.DropColumn(
                name: "Icon",
                schema: "ShoukouhPardis12DBAdmin",
                table: "WidgetGroup");

            migrationBuilder.DropColumn(
                name: "IconColor",
                schema: "ShoukouhPardis12DBAdmin",
                table: "WidgetGroup");

            migrationBuilder.DropColumn(
                name: "IconName",
                schema: "ShoukouhPardis12DBAdmin",
                table: "WidgetGroup");

            migrationBuilder.DropColumn(
                name: "IconSize",
                schema: "ShoukouhPardis12DBAdmin",
                table: "WidgetGroup");
        }
    }
}
