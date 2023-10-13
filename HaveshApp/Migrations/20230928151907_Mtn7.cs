using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShokouhApp.Migrations
{
    public partial class Mtn7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.AddColumn<Guid>(
            //    name: "LessonPlanGuid",
            //    schema: "ShoukouhPardis12DBAdmin",
            //    table: "ShokouhPardis_LessonPlan",
            //    type: "uniqueidentifier",
            //    nullable: false,
            //    defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            //migrationBuilder.AddColumn<DateTime>(
            //    name: "LessonPlanLastModified",
            //    schema: "ShoukouhPardis12DBAdmin",
            //    table: "ShokouhPardis_LessonPlan",
            //    type: "datetime2",
            //    nullable: false,
            //    defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LessonPlanGuid",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_LessonPlan");

            migrationBuilder.DropColumn(
                name: "LessonPlanLastModified",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_LessonPlan");
        }
    }
}
