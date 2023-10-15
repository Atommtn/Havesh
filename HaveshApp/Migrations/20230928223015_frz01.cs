using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HaveshApp.Migrations
{
    public partial class frz01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "ActivityDeletedDateTime",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_StudentSessionActivity",
                type: "datetime2",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ActivityDeletedDateTime",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_StudentSessionActivity");
        }
    }
}
