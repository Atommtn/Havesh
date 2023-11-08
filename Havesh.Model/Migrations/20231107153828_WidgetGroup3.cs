using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Havesh.Model.Migrations
{
    /// <inheritdoc />
    public partial class WidgetGroup3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "WidgetGroupId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "DashboardTemplateWidgets",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_DashboardTemplateWidgets_WidgetGroupId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "DashboardTemplateWidgets",
                column: "WidgetGroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_DashboardTemplateWidgets_WidgetGroup_WidgetGroupId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "DashboardTemplateWidgets",
                column: "WidgetGroupId",
                principalSchema: "ShoukouhPardis12DBAdmin",
                principalTable: "WidgetGroup",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DashboardTemplateWidgets_WidgetGroup_WidgetGroupId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "DashboardTemplateWidgets");

            migrationBuilder.DropIndex(
                name: "IX_DashboardTemplateWidgets_WidgetGroupId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "DashboardTemplateWidgets");

            migrationBuilder.DropColumn(
                name: "WidgetGroupId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "DashboardTemplateWidgets");
        }
    }
}
