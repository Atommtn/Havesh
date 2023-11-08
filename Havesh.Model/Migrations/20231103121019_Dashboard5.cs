using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Havesh.Model.Migrations
{
    /// <inheritdoc />
    public partial class Dashboard5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Hidden",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Widgets");

            migrationBuilder.DropColumn(
                name: "Order",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Widgets");

            migrationBuilder.AlterColumn<int>(
                name: "IconColor",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Widgets",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "DashboardWidgetSettings",
                schema: "ShoukouhPardis12DBAdmin",
                columns: table => new
                {
                    DashboardId = table.Column<int>(type: "int", nullable: false),
                    WidgetId = table.Column<int>(type: "int", nullable: false),
                    Order = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TitleClass = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Height = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IconSize = table.Column<int>(type: "int", nullable: true),
                    BreakPoints = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hidden = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DashboardWidgetSettings", x => new { x.DashboardId, x.WidgetId });
                    table.ForeignKey(
                        name: "FK_DashboardWidgetSettings_Dashboards_DashboardId",
                        column: x => x.DashboardId,
                        principalSchema: "ShoukouhPardis12DBAdmin",
                        principalTable: "Dashboards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DashboardWidgetSettings_Widgets_WidgetId",
                        column: x => x.WidgetId,
                        principalSchema: "ShoukouhPardis12DBAdmin",
                        principalTable: "Widgets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DashboardWidgetSettings_WidgetId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "DashboardWidgetSettings",
                column: "WidgetId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DashboardWidgetSettings",
                schema: "ShoukouhPardis12DBAdmin");

            migrationBuilder.AlterColumn<int>(
                name: "IconColor",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Widgets",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<bool>(
                name: "Hidden",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Widgets",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Order",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Widgets",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
