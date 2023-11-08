using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Havesh.Model.Migrations
{
    /// <inheritdoc />
    public partial class Dashboard6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Widgets_DashboardTemplates_DashboardTemplateId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Widgets");

            migrationBuilder.DropForeignKey(
                name: "FK_Widgets_Dashboards_DashboardId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Widgets");

            migrationBuilder.AlterColumn<int>(
                name: "DashboardTemplateId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Widgets",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DashboardId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Widgets",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Widgets_DashboardTemplates_DashboardTemplateId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Widgets",
                column: "DashboardTemplateId",
                principalSchema: "ShoukouhPardis12DBAdmin",
                principalTable: "DashboardTemplates",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Widgets_Dashboards_DashboardId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Widgets",
                column: "DashboardId",
                principalSchema: "ShoukouhPardis12DBAdmin",
                principalTable: "Dashboards",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Widgets_DashboardTemplates_DashboardTemplateId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Widgets");

            migrationBuilder.DropForeignKey(
                name: "FK_Widgets_Dashboards_DashboardId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Widgets");

            migrationBuilder.AlterColumn<int>(
                name: "DashboardTemplateId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Widgets",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "DashboardId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Widgets",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Widgets_DashboardTemplates_DashboardTemplateId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Widgets",
                column: "DashboardTemplateId",
                principalSchema: "ShoukouhPardis12DBAdmin",
                principalTable: "DashboardTemplates",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Widgets_Dashboards_DashboardId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Widgets",
                column: "DashboardId",
                principalSchema: "ShoukouhPardis12DBAdmin",
                principalTable: "Dashboards",
                principalColumn: "Id");
        }
    }
}
