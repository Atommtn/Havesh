using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Havesh.Model.Migrations
{
    /// <inheritdoc />
    public partial class SessionActivityIcon : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShokouhPardis_StudentSessionActivity_ShokouhPardis_SessionActivityValueOption_ActivityValueOptionFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_StudentSessionActivity");

            migrationBuilder.AlterColumn<int>(
                name: "ActivityValueOptionFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_StudentSessionActivity",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Icon",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_SessionActivityValueOption",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IconName",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_SessionActivityValueOption",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ShokouhPardis_StudentSessionActivity_TimeTableFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_StudentSessionActivity",
                column: "TimeTableFk");

            migrationBuilder.AddForeignKey(
                name: "FK_ShokouhPardis_StudentSessionActivity_ShokouhPardis_SessionActivityValueOption_ActivityValueOptionFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_StudentSessionActivity",
                column: "ActivityValueOptionFk",
                principalSchema: "ShoukouhPardis12DBAdmin",
                principalTable: "ShokouhPardis_SessionActivityValueOption",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_ShokouhPardis_StudentSessionActivity_ShokouhPardis_TimeTableSession_TimeTableFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_StudentSessionActivity",
                column: "TimeTableFk",
                principalSchema: "ShoukouhPardis12DBAdmin",
                principalTable: "ShokouhPardis_TimeTableSession",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShokouhPardis_StudentSessionActivity_ShokouhPardis_SessionActivityValueOption_ActivityValueOptionFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_StudentSessionActivity");

            migrationBuilder.DropForeignKey(
                name: "FK_ShokouhPardis_StudentSessionActivity_ShokouhPardis_TimeTableSession_TimeTableFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_StudentSessionActivity");

            migrationBuilder.DropIndex(
                name: "IX_ShokouhPardis_StudentSessionActivity_TimeTableFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_StudentSessionActivity");

            migrationBuilder.DropColumn(
                name: "Icon",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_SessionActivityValueOption");

            migrationBuilder.DropColumn(
                name: "IconName",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_SessionActivityValueOption");

            migrationBuilder.AlterColumn<int>(
                name: "ActivityValueOptionFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_StudentSessionActivity",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_ShokouhPardis_StudentSessionActivity_ShokouhPardis_SessionActivityValueOption_ActivityValueOptionFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_StudentSessionActivity",
                column: "ActivityValueOptionFk",
                principalSchema: "ShoukouhPardis12DBAdmin",
                principalTable: "ShokouhPardis_SessionActivityValueOption",
                principalColumn: "Id");
        }
    }
}
