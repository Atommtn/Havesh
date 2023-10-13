using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShokouhApp.Migrations
{
    public partial class frz_LessonPlan_Extented : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_LessonPlan");

            migrationBuilder.DropColumn(
                name: "Homework",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_LessonPlan");

            migrationBuilder.DropColumn(
                name: "LessonPlanGuid",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_LessonPlan");

            migrationBuilder.DropColumn(
                name: "LessonPlanLastModified",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_LessonPlan");

            migrationBuilder.RenameColumn(
                name: "SessionScope",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_LessonPlan",
                newName: "Title");

            migrationBuilder.CreateTable(
                name: "ShokouhPardis_LessonPlanSectionType",
                schema: "ShoukouhPardis12DBAdmin",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShokouhPardis_LessonPlanSectionType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ShokouhPardis_LessonPlanSection",
                schema: "ShoukouhPardis12DBAdmin",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LessonPlanFk = table.Column<int>(type: "int", nullable: false),
                    Order = table.Column<int>(type: "int", nullable: false),
                    SectionTypeFk = table.Column<int>(type: "int", nullable: false),
                    SectionTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Duration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SectionObjective = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShokouhPardis_LessonPlanSection", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShokouhPardis_LessonPlanSection_ShokouhPardis_LessonPlan_LessonPlanFk",
                        column: x => x.LessonPlanFk,
                        principalSchema: "ShoukouhPardis12DBAdmin",
                        principalTable: "ShokouhPardis_LessonPlan",
                        principalColumn: "LessonPlanId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShokouhPardis_LessonPlanSection_ShokouhPardis_LessonPlanSectionType_SectionTypeFk",
                        column: x => x.SectionTypeFk,
                        principalSchema: "ShoukouhPardis12DBAdmin",
                        principalTable: "ShokouhPardis_LessonPlanSectionType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShokouhPardis_LessonPlanSectionItem",
                schema: "ShoukouhPardis12DBAdmin",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LessonPlanSectionFk = table.Column<int>(type: "int", nullable: false),
                    Order = table.Column<int>(type: "int", nullable: false),
                    SectionItemTitle = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShokouhPardis_LessonPlanSectionItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShokouhPardis_LessonPlanSectionItem_ShokouhPardis_LessonPlanSection_LessonPlanSectionFk",
                        column: x => x.LessonPlanSectionFk,
                        principalSchema: "ShoukouhPardis12DBAdmin",
                        principalTable: "ShokouhPardis_LessonPlanSection",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ShokouhPardis_LessonPlanSection_LessonPlanFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_LessonPlanSection",
                column: "LessonPlanFk");

            migrationBuilder.CreateIndex(
                name: "IX_ShokouhPardis_LessonPlanSection_SectionTypeFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_LessonPlanSection",
                column: "SectionTypeFk");

            migrationBuilder.CreateIndex(
                name: "IX_ShokouhPardis_LessonPlanSectionItem_LessonPlanSectionFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_LessonPlanSectionItem",
                column: "LessonPlanSectionFk");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShokouhPardis_LessonPlanSectionItem",
                schema: "ShoukouhPardis12DBAdmin");

            migrationBuilder.DropTable(
                name: "ShokouhPardis_LessonPlanSection",
                schema: "ShoukouhPardis12DBAdmin");

            migrationBuilder.DropTable(
                name: "ShokouhPardis_LessonPlanSectionType",
                schema: "ShoukouhPardis12DBAdmin");

            migrationBuilder.RenameColumn(
                name: "Title",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_LessonPlan",
                newName: "SessionScope");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_LessonPlan",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Homework",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_LessonPlan",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LessonPlanGuid",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_LessonPlan",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "LessonPlanLastModified",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_LessonPlan",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
