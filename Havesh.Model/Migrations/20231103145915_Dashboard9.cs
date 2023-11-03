using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Havesh.Model.Migrations
{
    /// <inheritdoc />
    public partial class Dashboard9 : Migration
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

            migrationBuilder.DropIndex(
                name: "IX_Widgets_DashboardId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Widgets");

            migrationBuilder.DropIndex(
                name: "IX_Widgets_DashboardTemplateId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Widgets");

            migrationBuilder.DropColumn(
                name: "DashboardId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Widgets");

            migrationBuilder.DropColumn(
                name: "DashboardTemplateId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Widgets");

            migrationBuilder.AlterColumn<int>(
                name: "WidgetId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "DashboardWidgetSettings",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<int>(
                name: "DashboardId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "DashboardWidgetSettings",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("Relational:ColumnOrder", 1);

            migrationBuilder.CreateTable(
                name: "DashboardTemplateWidgets",
                schema: "ShoukouhPardis12DBAdmin",
                columns: table => new
                {
                    DashboardTemplateId = table.Column<int>(type: "int", nullable: false),
                    WidgetId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DashboardTemplateWidgets", x => new { x.DashboardTemplateId, x.WidgetId });
                    table.ForeignKey(
                        name: "FK_DashboardTemplateWidgets_DashboardTemplates_DashboardTemplateId",
                        column: x => x.DashboardTemplateId,
                        principalSchema: "ShoukouhPardis12DBAdmin",
                        principalTable: "DashboardTemplates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DashboardTemplateWidgets_Widgets_WidgetId",
                        column: x => x.WidgetId,
                        principalSchema: "ShoukouhPardis12DBAdmin",
                        principalTable: "Widgets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DashboardTemplateWidgets_WidgetId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "DashboardTemplateWidgets",
                column: "WidgetId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DashboardTemplateWidgets",
                schema: "ShoukouhPardis12DBAdmin");

            migrationBuilder.AddColumn<int>(
                name: "DashboardId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Widgets",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DashboardTemplateId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Widgets",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "WidgetId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "DashboardWidgetSettings",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<int>(
                name: "DashboardId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "DashboardWidgetSettings",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.CreateIndex(
                name: "IX_Widgets_DashboardId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Widgets",
                column: "DashboardId");

            migrationBuilder.CreateIndex(
                name: "IX_Widgets_DashboardTemplateId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Widgets",
                column: "DashboardTemplateId");

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
