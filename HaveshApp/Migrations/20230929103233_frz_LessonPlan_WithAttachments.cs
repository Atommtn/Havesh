using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShokouhApp.Migrations
{
    public partial class frz_LessonPlan_WithAttachments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ShokouhPardis_MediaAttachment",
                schema: "ShoukouhPardis12DBAdmin",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FileData = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShokouhPardis_MediaAttachment", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ShokouhPardis_LessonPlanAttachments",
                schema: "ShoukouhPardis12DBAdmin",
                columns: table => new
                {
                    LessonPlanId = table.Column<int>(type: "int", nullable: false),
                    AttachmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShokouhPardis_LessonPlanAttachments", x => new { x.LessonPlanId, x.AttachmentId });
                    table.ForeignKey(
                        name: "FK_ShokouhPardis_LessonPlanAttachments_ShokouhPardis_LessonPlan_LessonPlanId",
                        column: x => x.LessonPlanId,
                        principalSchema: "ShoukouhPardis12DBAdmin",
                        principalTable: "ShokouhPardis_LessonPlan",
                        principalColumn: "LessonPlanId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShokouhPardis_LessonPlanAttachments_ShokouhPardis_MediaAttachment_AttachmentId",
                        column: x => x.AttachmentId,
                        principalSchema: "ShoukouhPardis12DBAdmin",
                        principalTable: "ShokouhPardis_MediaAttachment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ShokouhPardis_LessonPlanAttachments_AttachmentId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_LessonPlanAttachments",
                column: "AttachmentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShokouhPardis_LessonPlanAttachments",
                schema: "ShoukouhPardis12DBAdmin");

            migrationBuilder.DropTable(
                name: "ShokouhPardis_MediaAttachment",
                schema: "ShoukouhPardis12DBAdmin");
        }
    }
}
