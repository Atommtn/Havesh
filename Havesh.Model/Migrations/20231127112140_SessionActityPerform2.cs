using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Havesh.Model.Migrations
{
    /// <inheritdoc />
    public partial class SessionActityPerform2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ActivityValueOptionFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_StudentSessionActivity",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ShokouhPardis_StudentSessionActivity_ActivityValueOptionFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_StudentSessionActivity",
                column: "ActivityValueOptionFk");

            migrationBuilder.AddForeignKey(
                name: "FK_ShokouhPardis_StudentSessionActivity_ShokouhPardis_SessionActivityValueOption_ActivityValueOptionFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_StudentSessionActivity",
                column: "ActivityValueOptionFk",
                principalSchema: "ShoukouhPardis12DBAdmin",
                principalTable: "ShokouhPardis_SessionActivityValueOption",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShokouhPardis_StudentSessionActivity_ShokouhPardis_SessionActivityValueOption_ActivityValueOptionFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_StudentSessionActivity");

            migrationBuilder.DropIndex(
                name: "IX_ShokouhPardis_StudentSessionActivity_ActivityValueOptionFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_StudentSessionActivity");

            migrationBuilder.DropColumn(
                name: "ActivityValueOptionFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_StudentSessionActivity");
        }
    }
}
