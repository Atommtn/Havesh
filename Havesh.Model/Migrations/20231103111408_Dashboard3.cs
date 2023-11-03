using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Havesh.Model.Migrations
{
    /// <inheritdoc />
    public partial class Dashboard3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "IconName",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Widgets",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IconName",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Widgets");
        }
    }
}
