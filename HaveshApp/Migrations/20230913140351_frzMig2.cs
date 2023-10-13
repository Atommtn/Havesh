using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShokouhApp.Migrations
{
    public partial class frzMig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ApplicationSettingsCategory",
                schema: "ShoukouhPardis12DBAdmin",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentCategoryFk = table.Column<int>(type: "int", nullable: true),
                    CategoryTitle = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationSettingsCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationSettings",
                schema: "ShoukouhPardis12DBAdmin",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SettingCategoryFk = table.Column<int>(type: "int", nullable: false),
                    SettingKey = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SettingValue = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationSettings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ApplicationSettings_ApplicationSettingsCategory_SettingCategoryFk",
                        column: x => x.SettingCategoryFk,
                        principalSchema: "ShoukouhPardis12DBAdmin",
                        principalTable: "ApplicationSettingsCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationSettings_SettingCategoryFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ApplicationSettings",
                column: "SettingCategoryFk");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplicationSettings",
                schema: "ShoukouhPardis12DBAdmin");

            migrationBuilder.DropTable(
                name: "ApplicationSettingsCategory",
                schema: "ShoukouhPardis12DBAdmin");
        }
    }
}
