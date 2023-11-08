using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Havesh.Model.Migrations
{
    /// <inheritdoc />
    public partial class DashboardWidgets1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IconColor",
                schema: "ShoukouhPardis12DBAdmin",
                table: "DashboardWidgetSettings",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IconName",
                schema: "ShoukouhPardis12DBAdmin",
                table: "DashboardWidgetSettings",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IconColor",
                schema: "ShoukouhPardis12DBAdmin",
                table: "DashboardWidgetSettings");

            migrationBuilder.DropColumn(
                name: "IconName",
                schema: "ShoukouhPardis12DBAdmin",
                table: "DashboardWidgetSettings");
        }
    }
}
