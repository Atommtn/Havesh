using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShokouhApp.Migrations
{
    public partial class mtn3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PreRegistrations_ShokouhPardis_DailyJV_DailyJVFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "PreRegistrations");

            migrationBuilder.DropForeignKey(
                name: "FK_PreRegistrations_ShokouhPardis_StudentClass_StudentFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "PreRegistrations");

            migrationBuilder.DropForeignKey(
                name: "FK_PreRegistrations_ShokouhPardis_TermClass_TermFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "PreRegistrations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PreRegistrations",
                schema: "ShoukouhPardis12DBAdmin",
                table: "PreRegistrations");

            migrationBuilder.RenameTable(
                name: "PreRegistrations",
                schema: "ShoukouhPardis12DBAdmin",
                newName: "ShokouhPardis_PreRegistration",
                newSchema: "ShoukouhPardis12DBAdmin");

            migrationBuilder.RenameIndex(
                name: "IX_PreRegistrations_TermFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_PreRegistration",
                newName: "IX_ShokouhPardis_PreRegistration_TermFk");

            migrationBuilder.RenameIndex(
                name: "IX_PreRegistrations_StudentFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_PreRegistration",
                newName: "IX_ShokouhPardis_PreRegistration_StudentFk");

            migrationBuilder.RenameIndex(
                name: "IX_PreRegistrations_DailyJVFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_PreRegistration",
                newName: "IX_ShokouhPardis_PreRegistration_DailyJVFk");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShokouhPardis_PreRegistration",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_PreRegistration",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ShokouhPardis_PreRegistration_ShokouhPardis_DailyJV_DailyJVFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_PreRegistration",
                column: "DailyJVFk",
                principalSchema: "ShoukouhPardis12DBAdmin",
                principalTable: "ShokouhPardis_DailyJV",
                principalColumn: "DailyJVID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ShokouhPardis_PreRegistration_ShokouhPardis_StudentClass_StudentFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_PreRegistration",
                column: "StudentFk",
                principalSchema: "dbo",
                principalTable: "ShokouhPardis_StudentClass",
                principalColumn: "StudentClassID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ShokouhPardis_PreRegistration_ShokouhPardis_TermClass_TermFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_PreRegistration",
                column: "TermFk",
                principalSchema: "dbo",
                principalTable: "ShokouhPardis_TermClass",
                principalColumn: "TermClassID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShokouhPardis_PreRegistration_ShokouhPardis_DailyJV_DailyJVFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_PreRegistration");

            migrationBuilder.DropForeignKey(
                name: "FK_ShokouhPardis_PreRegistration_ShokouhPardis_StudentClass_StudentFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_PreRegistration");

            migrationBuilder.DropForeignKey(
                name: "FK_ShokouhPardis_PreRegistration_ShokouhPardis_TermClass_TermFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_PreRegistration");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ShokouhPardis_PreRegistration",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_PreRegistration");

            migrationBuilder.RenameTable(
                name: "ShokouhPardis_PreRegistration",
                schema: "ShoukouhPardis12DBAdmin",
                newName: "PreRegistrations",
                newSchema: "ShoukouhPardis12DBAdmin");

            migrationBuilder.RenameIndex(
                name: "IX_ShokouhPardis_PreRegistration_TermFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "PreRegistrations",
                newName: "IX_PreRegistrations_TermFk");

            migrationBuilder.RenameIndex(
                name: "IX_ShokouhPardis_PreRegistration_StudentFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "PreRegistrations",
                newName: "IX_PreRegistrations_StudentFk");

            migrationBuilder.RenameIndex(
                name: "IX_ShokouhPardis_PreRegistration_DailyJVFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "PreRegistrations",
                newName: "IX_PreRegistrations_DailyJVFk");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PreRegistrations",
                schema: "ShoukouhPardis12DBAdmin",
                table: "PreRegistrations",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PreRegistrations_ShokouhPardis_DailyJV_DailyJVFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "PreRegistrations",
                column: "DailyJVFk",
                principalSchema: "ShoukouhPardis12DBAdmin",
                principalTable: "ShokouhPardis_DailyJV",
                principalColumn: "DailyJVID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PreRegistrations_ShokouhPardis_StudentClass_StudentFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "PreRegistrations",
                column: "StudentFk",
                principalSchema: "dbo",
                principalTable: "ShokouhPardis_StudentClass",
                principalColumn: "StudentClassID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PreRegistrations_ShokouhPardis_TermClass_TermFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "PreRegistrations",
                column: "TermFk",
                principalSchema: "dbo",
                principalTable: "ShokouhPardis_TermClass",
                principalColumn: "TermClassID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
