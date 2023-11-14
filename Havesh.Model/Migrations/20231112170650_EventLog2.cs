using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Havesh.Model.Migrations
{
    /// <inheritdoc />
    public partial class EventLog2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "OldValue",
                schema: "ShoukouhPardis12DBAdmin",
                table: "EntityChanges",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "NewValue",
                schema: "ShoukouhPardis12DBAdmin",
                table: "EntityChanges",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Field",
                schema: "ShoukouhPardis12DBAdmin",
                table: "EntityChanges",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "ActionById",
                schema: "ShoukouhPardis12DBAdmin",
                table: "EntityChanges",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "ActionWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "EntityChanges",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateIndex(
                name: "IX_EntityChanges_ActionById",
                schema: "ShoukouhPardis12DBAdmin",
                table: "EntityChanges",
                column: "ActionById");

            migrationBuilder.AddForeignKey(
                name: "FK_EntityChanges_Users_ActionById",
                schema: "ShoukouhPardis12DBAdmin",
                table: "EntityChanges",
                column: "ActionById",
                principalSchema: "ShoukouhPardis12DBAdmin",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EntityChanges_Users_ActionById",
                schema: "ShoukouhPardis12DBAdmin",
                table: "EntityChanges");

            migrationBuilder.DropIndex(
                name: "IX_EntityChanges_ActionById",
                schema: "ShoukouhPardis12DBAdmin",
                table: "EntityChanges");

            migrationBuilder.DropColumn(
                name: "ActionById",
                schema: "ShoukouhPardis12DBAdmin",
                table: "EntityChanges");

            migrationBuilder.DropColumn(
                name: "ActionWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "EntityChanges");

            migrationBuilder.AlterColumn<string>(
                name: "OldValue",
                schema: "ShoukouhPardis12DBAdmin",
                table: "EntityChanges",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NewValue",
                schema: "ShoukouhPardis12DBAdmin",
                table: "EntityChanges",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Field",
                schema: "ShoukouhPardis12DBAdmin",
                table: "EntityChanges",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
