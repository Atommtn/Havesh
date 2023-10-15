using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HaveshApp.Migrations
{
    public partial class mig5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "ActivityDateTime",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_StudentSessionActivity",
                type: "datetime2",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ActivityDateTime",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_StudentSessionActivity");
        }
    }
}
