using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HaveshApp.Migrations
{
    public partial class mig6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ShokouhPardis_SessionActivityValueOption",
                schema: "ShoukouhPardis12DBAdmin",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SessionActivityFk = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShokouhPardis_SessionActivityValueOption", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShokouhPardis_SessionActivityValueOption_ShokouhPardis_SessionActivity_SessionActivityFk",
                        column: x => x.SessionActivityFk,
                        principalSchema: "ShoukouhPardis12DBAdmin",
                        principalTable: "ShokouhPardis_SessionActivity",
                        principalColumn: "SessionActivityID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ShokouhPardis_SessionActivityValueOption_SessionActivityFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_SessionActivityValueOption",
                column: "SessionActivityFk");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShokouhPardis_SessionActivityValueOption",
                schema: "ShoukouhPardis12DBAdmin");
        }
    }
}
