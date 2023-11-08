using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Havesh.Model.Migrations
{
    /// <inheritdoc />
    public partial class Dashboard10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DashboardTemplateId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Dashboards",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Dashboards_DashboardTemplateId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Dashboards",
                column: "DashboardTemplateId");

            migrationBuilder.AddForeignKey(
                name: "FK_Dashboards_DashboardTemplates_DashboardTemplateId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Dashboards",
                column: "DashboardTemplateId",
                principalSchema: "ShoukouhPardis12DBAdmin",
                principalTable: "DashboardTemplates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dashboards_DashboardTemplates_DashboardTemplateId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Dashboards");

            migrationBuilder.DropIndex(
                name: "IX_Dashboards_DashboardTemplateId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Dashboards");

            migrationBuilder.DropColumn(
                name: "DashboardTemplateId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Dashboards");
        }
    }
}
