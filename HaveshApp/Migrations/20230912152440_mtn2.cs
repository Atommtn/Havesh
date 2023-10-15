using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HaveshApp.Migrations
{
    public partial class mtn2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PreRegistrations",
                schema: "ShoukouhPardis12DBAdmin",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DailyJVFk = table.Column<int>(type: "int", nullable: false),
                    StudentFk = table.Column<int>(type: "int", nullable: false),
                    TermFk = table.Column<int>(type: "int", nullable: false),
                    PreRegistrationGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PreRegistrationLastModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PreRegistrations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PreRegistrations_ShokouhPardis_DailyJV_DailyJVFk",
                        column: x => x.DailyJVFk,
                        principalSchema: "ShoukouhPardis12DBAdmin",
                        principalTable: "ShokouhPardis_DailyJV",
                        principalColumn: "DailyJVID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PreRegistrations_ShokouhPardis_StudentClass_StudentFk",
                        column: x => x.StudentFk,
                        principalSchema: "dbo",
                        principalTable: "ShokouhPardis_StudentClass",
                        principalColumn: "StudentClassID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PreRegistrations_ShokouhPardis_TermClass_TermFk",
                        column: x => x.TermFk,
                        principalSchema: "dbo",
                        principalTable: "ShokouhPardis_TermClass",
                        principalColumn: "TermClassID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PreRegistrations_DailyJVFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "PreRegistrations",
                column: "DailyJVFk");

            migrationBuilder.CreateIndex(
                name: "IX_PreRegistrations_StudentFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "PreRegistrations",
                column: "StudentFk");

            migrationBuilder.CreateIndex(
                name: "IX_PreRegistrations_TermFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "PreRegistrations",
                column: "TermFk");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PreRegistrations",
                schema: "ShoukouhPardis12DBAdmin");
        }
    }
}
