using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HaveshApp.Migrations
{
    public partial class mtn4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LevelFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_PreRegistration",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ShokouhPardis_PreRegistration_LevelFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_PreRegistration",
                column: "LevelFk");

            migrationBuilder.AddForeignKey(
                name: "FK_ShokouhPardis_PreRegistration_ShokouhPardis_LevelClass_LevelFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_PreRegistration",
                column: "LevelFk",
                principalSchema: "dbo",
                principalTable: "ShokouhPardis_LevelClass",
                principalColumn: "LevelClassID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShokouhPardis_PreRegistration_ShokouhPardis_LevelClass_LevelFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_PreRegistration");

            migrationBuilder.DropIndex(
                name: "IX_ShokouhPardis_PreRegistration_LevelFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_PreRegistration");

            migrationBuilder.DropColumn(
                name: "LevelFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_PreRegistration");
        }
    }
}
