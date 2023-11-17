using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Havesh.Model.Migrations
{
    /// <inheritdoc />
    public partial class WidgetDev_1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EntityChanges_Users_ActionById",
                schema: "ShoukouhPardis12DBAdmin",
                table: "EntityChanges");

            migrationBuilder.AddColumn<bool>(
                name: "IsInline",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Widgets",
                type: "bit",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EntityKey",
                schema: "ShoukouhPardis12DBAdmin",
                table: "EntityChanges",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "ActionById",
                schema: "ShoukouhPardis12DBAdmin",
                table: "EntityChanges",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_EntityChanges_Users_ActionById",
                schema: "ShoukouhPardis12DBAdmin",
                table: "EntityChanges",
                column: "ActionById",
                principalSchema: "ShoukouhPardis12DBAdmin",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EntityChanges_Users_ActionById",
                schema: "ShoukouhPardis12DBAdmin",
                table: "EntityChanges");

            migrationBuilder.DropColumn(
                name: "IsInline",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Widgets");

            migrationBuilder.AlterColumn<string>(
                name: "EntityKey",
                schema: "ShoukouhPardis12DBAdmin",
                table: "EntityChanges",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ActionById",
                schema: "ShoukouhPardis12DBAdmin",
                table: "EntityChanges",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_EntityChanges_Users_ActionById",
                schema: "ShoukouhPardis12DBAdmin",
                table: "EntityChanges",
                column: "ActionById",
                principalSchema: "ShoukouhPardis12DBAdmin",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
