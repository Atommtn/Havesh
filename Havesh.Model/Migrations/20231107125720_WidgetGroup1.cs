using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Havesh.Model.Migrations
{
    /// <inheritdoc />
    public partial class WidgetGroup1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "WidgetGroupId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "DashboardWidgetSettings",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "WidgetGroup",
                schema: "ShoukouhPardis12DBAdmin",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GroupType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WidgetGroup", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DashboardWidgetSettings_WidgetGroupId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "DashboardWidgetSettings",
                column: "WidgetGroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_DashboardWidgetSettings_WidgetGroup_WidgetGroupId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "DashboardWidgetSettings",
                column: "WidgetGroupId",
                principalSchema: "ShoukouhPardis12DBAdmin",
                principalTable: "WidgetGroup",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DashboardWidgetSettings_WidgetGroup_WidgetGroupId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "DashboardWidgetSettings");

            migrationBuilder.DropTable(
                name: "WidgetGroup",
                schema: "ShoukouhPardis12DBAdmin");

            migrationBuilder.DropIndex(
                name: "IX_DashboardWidgetSettings_WidgetGroupId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "DashboardWidgetSettings");

            migrationBuilder.DropColumn(
                name: "WidgetGroupId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "DashboardWidgetSettings");
        }
    }
}
