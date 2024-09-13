using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Havesh.Model.Migrations
{
    /// <inheritdoc />
    public partial class nextlastterm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LastTermFk",
                schema: "dbo",
                table: "ShokouhPardis_TermClass",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NextTermFk",
                schema: "dbo",
                table: "ShokouhPardis_TermClass",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastTermFk",
                schema: "dbo",
                table: "ShokouhPardis_TermClass");

            migrationBuilder.DropColumn(
                name: "NextTermFk",
                schema: "dbo",
                table: "ShokouhPardis_TermClass");
        }
    }
}
