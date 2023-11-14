using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Havesh.Model.Migrations
{
    /// <inheritdoc />
    public partial class BaseModels_1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "Guid",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Users",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Users",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                schema: "dbo",
                table: "ShokouhPardis_YearClass",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedWhen",
                schema: "dbo",
                table: "ShokouhPardis_YearClass",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "Guid",
                schema: "dbo",
                table: "ShokouhPardis_YearClass",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "dbo",
                table: "ShokouhPardis_YearClass",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedByUserId",
                schema: "dbo",
                table: "ShokouhPardis_YearClass",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedWhen",
                schema: "dbo",
                table: "ShokouhPardis_YearClass",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                schema: "dbo",
                table: "ShokouhPardis_WeekDay",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedWhen",
                schema: "dbo",
                table: "ShokouhPardis_WeekDay",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "Guid",
                schema: "dbo",
                table: "ShokouhPardis_WeekDay",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "dbo",
                table: "ShokouhPardis_WeekDay",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedByUserId",
                schema: "dbo",
                table: "ShokouhPardis_WeekDay",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedWhen",
                schema: "dbo",
                table: "ShokouhPardis_WeekDay",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TimeTableStudents",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TimeTableStudents",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "Guid",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TimeTableStudents",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TimeTableStudents",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TimeTableStudents",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TimeTableStudents",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TimeTableSession",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TimeTableSession",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "Guid",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TimeTableSession",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TimeTableSession",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TimeTableSession",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TimeTableSession",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TimeTable",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TimeTable",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "Guid",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TimeTable",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TimeTable",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TimeTable",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TimeTable",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TermSessionTemplateDate",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TermSessionTemplateDate",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "Guid",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TermSessionTemplateDate",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TermSessionTemplateDate",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TermSessionTemplateDate",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TermSessionTemplateDate",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TermSessionTemplate",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TermSessionTemplate",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "Guid",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TermSessionTemplate",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TermSessionTemplate",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TermSessionTemplate",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TermSessionTemplate",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                schema: "dbo",
                table: "ShokouhPardis_TermClass",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedWhen",
                schema: "dbo",
                table: "ShokouhPardis_TermClass",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "Guid",
                schema: "dbo",
                table: "ShokouhPardis_TermClass",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "dbo",
                table: "ShokouhPardis_TermClass",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedByUserId",
                schema: "dbo",
                table: "ShokouhPardis_TermClass",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedWhen",
                schema: "dbo",
                table: "ShokouhPardis_TermClass",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TeacherTimeSheet",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TeacherTimeSheet",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "Guid",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TeacherTimeSheet",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TeacherTimeSheet",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TeacherTimeSheet",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TeacherTimeSheet",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TeacherTermClass",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TeacherTermClass",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TeacherTermClass",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TeacherTermClass",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TeacherTermClass",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TeacherLevels",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TeacherLevels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "Guid",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TeacherLevels",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TeacherLevels",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TeacherLevels",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TeacherLevels",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                schema: "dbo",
                table: "ShokouhPardis_TeacherClass",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedWhen",
                schema: "dbo",
                table: "ShokouhPardis_TeacherClass",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "Guid",
                schema: "dbo",
                table: "ShokouhPardis_TeacherClass",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "dbo",
                table: "ShokouhPardis_TeacherClass",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedByUserId",
                schema: "dbo",
                table: "ShokouhPardis_TeacherClass",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedWhen",
                schema: "dbo",
                table: "ShokouhPardis_TeacherClass",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_StudentSessionActivity",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_StudentSessionActivity",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "Guid",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_StudentSessionActivity",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_StudentSessionActivity",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_StudentSessionActivity",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_StudentSessionActivity",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_StudentClass_OnlineForm",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_StudentClass_OnlineForm",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "Guid",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_StudentClass_OnlineForm",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_StudentClass_OnlineForm",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_StudentClass_OnlineForm",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_StudentClass_OnlineForm",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_StudentClass_Dto",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_StudentClass_Dto",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "Guid",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_StudentClass_Dto",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_StudentClass_Dto",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_StudentClass_Dto",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_StudentClass_Dto",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                schema: "dbo",
                table: "ShokouhPardis_StudentClass",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedWhen",
                schema: "dbo",
                table: "ShokouhPardis_StudentClass",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "Guid",
                schema: "dbo",
                table: "ShokouhPardis_StudentClass",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "dbo",
                table: "ShokouhPardis_StudentClass",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedByUserId",
                schema: "dbo",
                table: "ShokouhPardis_StudentClass",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedWhen",
                schema: "dbo",
                table: "ShokouhPardis_StudentClass",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_SessionActivityValueOption",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_SessionActivityValueOption",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "Guid",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_SessionActivityValueOption",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_SessionActivityValueOption",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_SessionActivityValueOption",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_SessionActivityValueOption",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_SessionActivity",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_SessionActivity",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "Guid",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_SessionActivity",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_SessionActivity",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_SessionActivity",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_SessionActivity",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                schema: "dbo",
                table: "ShokouhPardis_schedule",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedWhen",
                schema: "dbo",
                table: "ShokouhPardis_schedule",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "Guid",
                schema: "dbo",
                table: "ShokouhPardis_schedule",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "dbo",
                table: "ShokouhPardis_schedule",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedByUserId",
                schema: "dbo",
                table: "ShokouhPardis_schedule",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedWhen",
                schema: "dbo",
                table: "ShokouhPardis_schedule",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                schema: "dbo",
                table: "ShokouhPardis_Program",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedWhen",
                schema: "dbo",
                table: "ShokouhPardis_Program",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "Guid",
                schema: "dbo",
                table: "ShokouhPardis_Program",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "dbo",
                table: "ShokouhPardis_Program",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedByUserId",
                schema: "dbo",
                table: "ShokouhPardis_Program",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedWhen",
                schema: "dbo",
                table: "ShokouhPardis_Program",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_PreRegistration",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_PreRegistration",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "Guid",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_PreRegistration",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_PreRegistration",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_PreRegistration",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_PreRegistration",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_MediaAttachment",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_MediaAttachment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "Guid",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_MediaAttachment",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_MediaAttachment",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_MediaAttachment",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_MediaAttachment",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                schema: "dbo",
                table: "ShokouhPardis_LevelClass",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedWhen",
                schema: "dbo",
                table: "ShokouhPardis_LevelClass",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "Guid",
                schema: "dbo",
                table: "ShokouhPardis_LevelClass",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "dbo",
                table: "ShokouhPardis_LevelClass",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedByUserId",
                schema: "dbo",
                table: "ShokouhPardis_LevelClass",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedWhen",
                schema: "dbo",
                table: "ShokouhPardis_LevelClass",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_LevelBookPrice",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_LevelBookPrice",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "Guid",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_LevelBookPrice",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_LevelBookPrice",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_LevelBookPrice",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_LevelBookPrice",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_LessonPlanSectionType",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_LessonPlanSectionType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "Guid",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_LessonPlanSectionType",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_LessonPlanSectionType",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_LessonPlanSectionType",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_LessonPlanSectionType",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_LessonPlanSection",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_LessonPlanSection",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "Guid",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_LessonPlanSection",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_LessonPlanSection",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_LessonPlanSection",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_LessonPlanSection",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_LessonPlan",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_LessonPlan",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "Guid",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_LessonPlan",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_LessonPlan",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_LessonPlan",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_LessonPlan",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_JVFromSite",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_JVFromSite",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "Guid",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_JVFromSite",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_JVFromSite",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_JVFromSite",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_JVFromSite",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                schema: "dbo",
                table: "ShokouhPardis_Interval",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedWhen",
                schema: "dbo",
                table: "ShokouhPardis_Interval",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "Guid",
                schema: "dbo",
                table: "ShokouhPardis_Interval",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "dbo",
                table: "ShokouhPardis_Interval",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedByUserId",
                schema: "dbo",
                table: "ShokouhPardis_Interval",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedWhen",
                schema: "dbo",
                table: "ShokouhPardis_Interval",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_Finance_Flat",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_Finance_Flat",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "Guid",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_Finance_Flat",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_Finance_Flat",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_Finance_Flat",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_Finance_Flat",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_FileAttachment",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_FileAttachment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_FileAttachment",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_FileAttachment",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_FileAttachment",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_Employee",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "Guid",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_Employee",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_Employee",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_Employee",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_Employee",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                schema: "dbo",
                table: "ShokouhPardis_DaySession",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedWhen",
                schema: "dbo",
                table: "ShokouhPardis_DaySession",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "Guid",
                schema: "dbo",
                table: "ShokouhPardis_DaySession",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "dbo",
                table: "ShokouhPardis_DaySession",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedByUserId",
                schema: "dbo",
                table: "ShokouhPardis_DaySession",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedWhen",
                schema: "dbo",
                table: "ShokouhPardis_DaySession",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_DailyJV",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_DailyJV",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "Guid",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_DailyJV",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_DailyJV",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_DailyJV",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_DailyJV",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                schema: "dbo",
                table: "ShokouhPardis_ClassRoom",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedWhen",
                schema: "dbo",
                table: "ShokouhPardis_ClassRoom",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "Guid",
                schema: "dbo",
                table: "ShokouhPardis_ClassRoom",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "dbo",
                table: "ShokouhPardis_ClassRoom",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedByUserId",
                schema: "dbo",
                table: "ShokouhPardis_ClassRoom",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedWhen",
                schema: "dbo",
                table: "ShokouhPardis_ClassRoom",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                schema: "dbo",
                table: "ShokouhPardis_BookClass",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedWhen",
                schema: "dbo",
                table: "ShokouhPardis_BookClass",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "Guid",
                schema: "dbo",
                table: "ShokouhPardis_BookClass",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "dbo",
                table: "ShokouhPardis_BookClass",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedByUserId",
                schema: "dbo",
                table: "ShokouhPardis_BookClass",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedWhen",
                schema: "dbo",
                table: "ShokouhPardis_BookClass",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_AccountingTransaction",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_AccountingTransaction",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "Guid",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_AccountingTransaction",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_AccountingTransaction",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_AccountingTransaction",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_AccountingTransaction",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_AccountingCode",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_AccountingCode",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "Guid",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_AccountingCode",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_AccountingCode",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_AccountingCode",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_AccountingCode",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Roles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "Guid",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Roles",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Roles",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Roles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Roles",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Permissions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Permissions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "Guid",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Permissions",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Permissions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Permissions",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Permissions",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Messages",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Messages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "Guid",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Messages",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Messages",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Messages",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Messages",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "MessageBoxes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "MessageBoxes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "Guid",
                schema: "ShoukouhPardis12DBAdmin",
                table: "MessageBoxes",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "ShoukouhPardis12DBAdmin",
                table: "MessageBoxes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "MessageBoxes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "MessageBoxes",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "MessageActions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "MessageActions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "Guid",
                schema: "ShoukouhPardis12DBAdmin",
                table: "MessageActions",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "ShoukouhPardis12DBAdmin",
                table: "MessageActions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "MessageActions",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "MessageActions",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "MessageActionOptions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "MessageActionOptions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "Guid",
                schema: "ShoukouhPardis12DBAdmin",
                table: "MessageActionOptions",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "ShoukouhPardis12DBAdmin",
                table: "MessageActionOptions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "MessageActionOptions",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "MessageActionOptions",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "AdvanceRegistrations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "AdvanceRegistrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "Guid",
                schema: "ShoukouhPardis12DBAdmin",
                table: "AdvanceRegistrations",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "ShoukouhPardis12DBAdmin",
                table: "AdvanceRegistrations",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "AdvanceRegistrations",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "AdvanceRegistrations",
                type: "datetime2",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "CreatedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Guid",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ModifiedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ModifiedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                schema: "dbo",
                table: "ShokouhPardis_YearClass");

            migrationBuilder.DropColumn(
                name: "CreatedWhen",
                schema: "dbo",
                table: "ShokouhPardis_YearClass");

            migrationBuilder.DropColumn(
                name: "Guid",
                schema: "dbo",
                table: "ShokouhPardis_YearClass");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "dbo",
                table: "ShokouhPardis_YearClass");

            migrationBuilder.DropColumn(
                name: "ModifiedByUserId",
                schema: "dbo",
                table: "ShokouhPardis_YearClass");

            migrationBuilder.DropColumn(
                name: "ModifiedWhen",
                schema: "dbo",
                table: "ShokouhPardis_YearClass");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                schema: "dbo",
                table: "ShokouhPardis_WeekDay");

            migrationBuilder.DropColumn(
                name: "CreatedWhen",
                schema: "dbo",
                table: "ShokouhPardis_WeekDay");

            migrationBuilder.DropColumn(
                name: "Guid",
                schema: "dbo",
                table: "ShokouhPardis_WeekDay");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "dbo",
                table: "ShokouhPardis_WeekDay");

            migrationBuilder.DropColumn(
                name: "ModifiedByUserId",
                schema: "dbo",
                table: "ShokouhPardis_WeekDay");

            migrationBuilder.DropColumn(
                name: "ModifiedWhen",
                schema: "dbo",
                table: "ShokouhPardis_WeekDay");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TimeTableStudents");

            migrationBuilder.DropColumn(
                name: "CreatedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TimeTableStudents");

            migrationBuilder.DropColumn(
                name: "Guid",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TimeTableStudents");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TimeTableStudents");

            migrationBuilder.DropColumn(
                name: "ModifiedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TimeTableStudents");

            migrationBuilder.DropColumn(
                name: "ModifiedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TimeTableStudents");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TimeTableSession");

            migrationBuilder.DropColumn(
                name: "CreatedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TimeTableSession");

            migrationBuilder.DropColumn(
                name: "Guid",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TimeTableSession");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TimeTableSession");

            migrationBuilder.DropColumn(
                name: "ModifiedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TimeTableSession");

            migrationBuilder.DropColumn(
                name: "ModifiedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TimeTableSession");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TimeTable");

            migrationBuilder.DropColumn(
                name: "CreatedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TimeTable");

            migrationBuilder.DropColumn(
                name: "Guid",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TimeTable");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TimeTable");

            migrationBuilder.DropColumn(
                name: "ModifiedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TimeTable");

            migrationBuilder.DropColumn(
                name: "ModifiedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TimeTable");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TermSessionTemplateDate");

            migrationBuilder.DropColumn(
                name: "CreatedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TermSessionTemplateDate");

            migrationBuilder.DropColumn(
                name: "Guid",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TermSessionTemplateDate");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TermSessionTemplateDate");

            migrationBuilder.DropColumn(
                name: "ModifiedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TermSessionTemplateDate");

            migrationBuilder.DropColumn(
                name: "ModifiedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TermSessionTemplateDate");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TermSessionTemplate");

            migrationBuilder.DropColumn(
                name: "CreatedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TermSessionTemplate");

            migrationBuilder.DropColumn(
                name: "Guid",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TermSessionTemplate");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TermSessionTemplate");

            migrationBuilder.DropColumn(
                name: "ModifiedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TermSessionTemplate");

            migrationBuilder.DropColumn(
                name: "ModifiedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TermSessionTemplate");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                schema: "dbo",
                table: "ShokouhPardis_TermClass");

            migrationBuilder.DropColumn(
                name: "CreatedWhen",
                schema: "dbo",
                table: "ShokouhPardis_TermClass");

            migrationBuilder.DropColumn(
                name: "Guid",
                schema: "dbo",
                table: "ShokouhPardis_TermClass");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "dbo",
                table: "ShokouhPardis_TermClass");

            migrationBuilder.DropColumn(
                name: "ModifiedByUserId",
                schema: "dbo",
                table: "ShokouhPardis_TermClass");

            migrationBuilder.DropColumn(
                name: "ModifiedWhen",
                schema: "dbo",
                table: "ShokouhPardis_TermClass");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TeacherTimeSheet");

            migrationBuilder.DropColumn(
                name: "CreatedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TeacherTimeSheet");

            migrationBuilder.DropColumn(
                name: "Guid",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TeacherTimeSheet");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TeacherTimeSheet");

            migrationBuilder.DropColumn(
                name: "ModifiedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TeacherTimeSheet");

            migrationBuilder.DropColumn(
                name: "ModifiedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TeacherTimeSheet");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TeacherTermClass");

            migrationBuilder.DropColumn(
                name: "CreatedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TeacherTermClass");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TeacherTermClass");

            migrationBuilder.DropColumn(
                name: "ModifiedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TeacherTermClass");

            migrationBuilder.DropColumn(
                name: "ModifiedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TeacherTermClass");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TeacherLevels");

            migrationBuilder.DropColumn(
                name: "CreatedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TeacherLevels");

            migrationBuilder.DropColumn(
                name: "Guid",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TeacherLevels");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TeacherLevels");

            migrationBuilder.DropColumn(
                name: "ModifiedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TeacherLevels");

            migrationBuilder.DropColumn(
                name: "ModifiedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TeacherLevels");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                schema: "dbo",
                table: "ShokouhPardis_TeacherClass");

            migrationBuilder.DropColumn(
                name: "CreatedWhen",
                schema: "dbo",
                table: "ShokouhPardis_TeacherClass");

            migrationBuilder.DropColumn(
                name: "Guid",
                schema: "dbo",
                table: "ShokouhPardis_TeacherClass");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "dbo",
                table: "ShokouhPardis_TeacherClass");

            migrationBuilder.DropColumn(
                name: "ModifiedByUserId",
                schema: "dbo",
                table: "ShokouhPardis_TeacherClass");

            migrationBuilder.DropColumn(
                name: "ModifiedWhen",
                schema: "dbo",
                table: "ShokouhPardis_TeacherClass");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_StudentSessionActivity");

            migrationBuilder.DropColumn(
                name: "CreatedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_StudentSessionActivity");

            migrationBuilder.DropColumn(
                name: "Guid",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_StudentSessionActivity");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_StudentSessionActivity");

            migrationBuilder.DropColumn(
                name: "ModifiedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_StudentSessionActivity");

            migrationBuilder.DropColumn(
                name: "ModifiedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_StudentSessionActivity");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_StudentClass_OnlineForm");

            migrationBuilder.DropColumn(
                name: "CreatedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_StudentClass_OnlineForm");

            migrationBuilder.DropColumn(
                name: "Guid",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_StudentClass_OnlineForm");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_StudentClass_OnlineForm");

            migrationBuilder.DropColumn(
                name: "ModifiedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_StudentClass_OnlineForm");

            migrationBuilder.DropColumn(
                name: "ModifiedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_StudentClass_OnlineForm");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_StudentClass_Dto");

            migrationBuilder.DropColumn(
                name: "CreatedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_StudentClass_Dto");

            migrationBuilder.DropColumn(
                name: "Guid",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_StudentClass_Dto");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_StudentClass_Dto");

            migrationBuilder.DropColumn(
                name: "ModifiedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_StudentClass_Dto");

            migrationBuilder.DropColumn(
                name: "ModifiedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_StudentClass_Dto");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                schema: "dbo",
                table: "ShokouhPardis_StudentClass");

            migrationBuilder.DropColumn(
                name: "CreatedWhen",
                schema: "dbo",
                table: "ShokouhPardis_StudentClass");

            migrationBuilder.DropColumn(
                name: "Guid",
                schema: "dbo",
                table: "ShokouhPardis_StudentClass");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "dbo",
                table: "ShokouhPardis_StudentClass");

            migrationBuilder.DropColumn(
                name: "ModifiedByUserId",
                schema: "dbo",
                table: "ShokouhPardis_StudentClass");

            migrationBuilder.DropColumn(
                name: "ModifiedWhen",
                schema: "dbo",
                table: "ShokouhPardis_StudentClass");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_SessionActivityValueOption");

            migrationBuilder.DropColumn(
                name: "CreatedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_SessionActivityValueOption");

            migrationBuilder.DropColumn(
                name: "Guid",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_SessionActivityValueOption");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_SessionActivityValueOption");

            migrationBuilder.DropColumn(
                name: "ModifiedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_SessionActivityValueOption");

            migrationBuilder.DropColumn(
                name: "ModifiedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_SessionActivityValueOption");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_SessionActivity");

            migrationBuilder.DropColumn(
                name: "CreatedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_SessionActivity");

            migrationBuilder.DropColumn(
                name: "Guid",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_SessionActivity");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_SessionActivity");

            migrationBuilder.DropColumn(
                name: "ModifiedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_SessionActivity");

            migrationBuilder.DropColumn(
                name: "ModifiedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_SessionActivity");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                schema: "dbo",
                table: "ShokouhPardis_schedule");

            migrationBuilder.DropColumn(
                name: "CreatedWhen",
                schema: "dbo",
                table: "ShokouhPardis_schedule");

            migrationBuilder.DropColumn(
                name: "Guid",
                schema: "dbo",
                table: "ShokouhPardis_schedule");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "dbo",
                table: "ShokouhPardis_schedule");

            migrationBuilder.DropColumn(
                name: "ModifiedByUserId",
                schema: "dbo",
                table: "ShokouhPardis_schedule");

            migrationBuilder.DropColumn(
                name: "ModifiedWhen",
                schema: "dbo",
                table: "ShokouhPardis_schedule");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                schema: "dbo",
                table: "ShokouhPardis_Program");

            migrationBuilder.DropColumn(
                name: "CreatedWhen",
                schema: "dbo",
                table: "ShokouhPardis_Program");

            migrationBuilder.DropColumn(
                name: "Guid",
                schema: "dbo",
                table: "ShokouhPardis_Program");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "dbo",
                table: "ShokouhPardis_Program");

            migrationBuilder.DropColumn(
                name: "ModifiedByUserId",
                schema: "dbo",
                table: "ShokouhPardis_Program");

            migrationBuilder.DropColumn(
                name: "ModifiedWhen",
                schema: "dbo",
                table: "ShokouhPardis_Program");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_PreRegistration");

            migrationBuilder.DropColumn(
                name: "CreatedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_PreRegistration");

            migrationBuilder.DropColumn(
                name: "Guid",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_PreRegistration");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_PreRegistration");

            migrationBuilder.DropColumn(
                name: "ModifiedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_PreRegistration");

            migrationBuilder.DropColumn(
                name: "ModifiedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_PreRegistration");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_MediaAttachment");

            migrationBuilder.DropColumn(
                name: "CreatedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_MediaAttachment");

            migrationBuilder.DropColumn(
                name: "Guid",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_MediaAttachment");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_MediaAttachment");

            migrationBuilder.DropColumn(
                name: "ModifiedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_MediaAttachment");

            migrationBuilder.DropColumn(
                name: "ModifiedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_MediaAttachment");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                schema: "dbo",
                table: "ShokouhPardis_LevelClass");

            migrationBuilder.DropColumn(
                name: "CreatedWhen",
                schema: "dbo",
                table: "ShokouhPardis_LevelClass");

            migrationBuilder.DropColumn(
                name: "Guid",
                schema: "dbo",
                table: "ShokouhPardis_LevelClass");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "dbo",
                table: "ShokouhPardis_LevelClass");

            migrationBuilder.DropColumn(
                name: "ModifiedByUserId",
                schema: "dbo",
                table: "ShokouhPardis_LevelClass");

            migrationBuilder.DropColumn(
                name: "ModifiedWhen",
                schema: "dbo",
                table: "ShokouhPardis_LevelClass");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_LevelBookPrice");

            migrationBuilder.DropColumn(
                name: "CreatedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_LevelBookPrice");

            migrationBuilder.DropColumn(
                name: "Guid",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_LevelBookPrice");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_LevelBookPrice");

            migrationBuilder.DropColumn(
                name: "ModifiedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_LevelBookPrice");

            migrationBuilder.DropColumn(
                name: "ModifiedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_LevelBookPrice");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_LessonPlanSectionType");

            migrationBuilder.DropColumn(
                name: "CreatedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_LessonPlanSectionType");

            migrationBuilder.DropColumn(
                name: "Guid",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_LessonPlanSectionType");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_LessonPlanSectionType");

            migrationBuilder.DropColumn(
                name: "ModifiedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_LessonPlanSectionType");

            migrationBuilder.DropColumn(
                name: "ModifiedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_LessonPlanSectionType");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_LessonPlanSection");

            migrationBuilder.DropColumn(
                name: "CreatedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_LessonPlanSection");

            migrationBuilder.DropColumn(
                name: "Guid",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_LessonPlanSection");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_LessonPlanSection");

            migrationBuilder.DropColumn(
                name: "ModifiedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_LessonPlanSection");

            migrationBuilder.DropColumn(
                name: "ModifiedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_LessonPlanSection");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_LessonPlan");

            migrationBuilder.DropColumn(
                name: "CreatedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_LessonPlan");

            migrationBuilder.DropColumn(
                name: "Guid",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_LessonPlan");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_LessonPlan");

            migrationBuilder.DropColumn(
                name: "ModifiedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_LessonPlan");

            migrationBuilder.DropColumn(
                name: "ModifiedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_LessonPlan");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_JVFromSite");

            migrationBuilder.DropColumn(
                name: "CreatedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_JVFromSite");

            migrationBuilder.DropColumn(
                name: "Guid",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_JVFromSite");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_JVFromSite");

            migrationBuilder.DropColumn(
                name: "ModifiedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_JVFromSite");

            migrationBuilder.DropColumn(
                name: "ModifiedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_JVFromSite");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                schema: "dbo",
                table: "ShokouhPardis_Interval");

            migrationBuilder.DropColumn(
                name: "CreatedWhen",
                schema: "dbo",
                table: "ShokouhPardis_Interval");

            migrationBuilder.DropColumn(
                name: "Guid",
                schema: "dbo",
                table: "ShokouhPardis_Interval");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "dbo",
                table: "ShokouhPardis_Interval");

            migrationBuilder.DropColumn(
                name: "ModifiedByUserId",
                schema: "dbo",
                table: "ShokouhPardis_Interval");

            migrationBuilder.DropColumn(
                name: "ModifiedWhen",
                schema: "dbo",
                table: "ShokouhPardis_Interval");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_Finance_Flat");

            migrationBuilder.DropColumn(
                name: "CreatedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_Finance_Flat");

            migrationBuilder.DropColumn(
                name: "Guid",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_Finance_Flat");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_Finance_Flat");

            migrationBuilder.DropColumn(
                name: "ModifiedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_Finance_Flat");

            migrationBuilder.DropColumn(
                name: "ModifiedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_Finance_Flat");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_FileAttachment");

            migrationBuilder.DropColumn(
                name: "CreatedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_FileAttachment");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_FileAttachment");

            migrationBuilder.DropColumn(
                name: "ModifiedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_FileAttachment");

            migrationBuilder.DropColumn(
                name: "ModifiedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_FileAttachment");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_Employee");

            migrationBuilder.DropColumn(
                name: "CreatedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_Employee");

            migrationBuilder.DropColumn(
                name: "Guid",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_Employee");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_Employee");

            migrationBuilder.DropColumn(
                name: "ModifiedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_Employee");

            migrationBuilder.DropColumn(
                name: "ModifiedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_Employee");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                schema: "dbo",
                table: "ShokouhPardis_DaySession");

            migrationBuilder.DropColumn(
                name: "CreatedWhen",
                schema: "dbo",
                table: "ShokouhPardis_DaySession");

            migrationBuilder.DropColumn(
                name: "Guid",
                schema: "dbo",
                table: "ShokouhPardis_DaySession");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "dbo",
                table: "ShokouhPardis_DaySession");

            migrationBuilder.DropColumn(
                name: "ModifiedByUserId",
                schema: "dbo",
                table: "ShokouhPardis_DaySession");

            migrationBuilder.DropColumn(
                name: "ModifiedWhen",
                schema: "dbo",
                table: "ShokouhPardis_DaySession");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_DailyJV");

            migrationBuilder.DropColumn(
                name: "CreatedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_DailyJV");

            migrationBuilder.DropColumn(
                name: "Guid",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_DailyJV");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_DailyJV");

            migrationBuilder.DropColumn(
                name: "ModifiedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_DailyJV");

            migrationBuilder.DropColumn(
                name: "ModifiedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_DailyJV");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                schema: "dbo",
                table: "ShokouhPardis_ClassRoom");

            migrationBuilder.DropColumn(
                name: "CreatedWhen",
                schema: "dbo",
                table: "ShokouhPardis_ClassRoom");

            migrationBuilder.DropColumn(
                name: "Guid",
                schema: "dbo",
                table: "ShokouhPardis_ClassRoom");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "dbo",
                table: "ShokouhPardis_ClassRoom");

            migrationBuilder.DropColumn(
                name: "ModifiedByUserId",
                schema: "dbo",
                table: "ShokouhPardis_ClassRoom");

            migrationBuilder.DropColumn(
                name: "ModifiedWhen",
                schema: "dbo",
                table: "ShokouhPardis_ClassRoom");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                schema: "dbo",
                table: "ShokouhPardis_BookClass");

            migrationBuilder.DropColumn(
                name: "CreatedWhen",
                schema: "dbo",
                table: "ShokouhPardis_BookClass");

            migrationBuilder.DropColumn(
                name: "Guid",
                schema: "dbo",
                table: "ShokouhPardis_BookClass");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "dbo",
                table: "ShokouhPardis_BookClass");

            migrationBuilder.DropColumn(
                name: "ModifiedByUserId",
                schema: "dbo",
                table: "ShokouhPardis_BookClass");

            migrationBuilder.DropColumn(
                name: "ModifiedWhen",
                schema: "dbo",
                table: "ShokouhPardis_BookClass");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_AccountingTransaction");

            migrationBuilder.DropColumn(
                name: "CreatedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_AccountingTransaction");

            migrationBuilder.DropColumn(
                name: "Guid",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_AccountingTransaction");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_AccountingTransaction");

            migrationBuilder.DropColumn(
                name: "ModifiedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_AccountingTransaction");

            migrationBuilder.DropColumn(
                name: "ModifiedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_AccountingTransaction");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_AccountingCode");

            migrationBuilder.DropColumn(
                name: "CreatedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_AccountingCode");

            migrationBuilder.DropColumn(
                name: "Guid",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_AccountingCode");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_AccountingCode");

            migrationBuilder.DropColumn(
                name: "ModifiedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_AccountingCode");

            migrationBuilder.DropColumn(
                name: "ModifiedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_AccountingCode");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "CreatedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "Guid",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "ModifiedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "ModifiedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Permissions");

            migrationBuilder.DropColumn(
                name: "CreatedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Permissions");

            migrationBuilder.DropColumn(
                name: "Guid",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Permissions");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Permissions");

            migrationBuilder.DropColumn(
                name: "ModifiedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Permissions");

            migrationBuilder.DropColumn(
                name: "ModifiedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Permissions");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "CreatedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "Guid",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "ModifiedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "ModifiedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "MessageBoxes");

            migrationBuilder.DropColumn(
                name: "CreatedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "MessageBoxes");

            migrationBuilder.DropColumn(
                name: "Guid",
                schema: "ShoukouhPardis12DBAdmin",
                table: "MessageBoxes");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "ShoukouhPardis12DBAdmin",
                table: "MessageBoxes");

            migrationBuilder.DropColumn(
                name: "ModifiedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "MessageBoxes");

            migrationBuilder.DropColumn(
                name: "ModifiedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "MessageBoxes");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "MessageActions");

            migrationBuilder.DropColumn(
                name: "CreatedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "MessageActions");

            migrationBuilder.DropColumn(
                name: "Guid",
                schema: "ShoukouhPardis12DBAdmin",
                table: "MessageActions");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "ShoukouhPardis12DBAdmin",
                table: "MessageActions");

            migrationBuilder.DropColumn(
                name: "ModifiedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "MessageActions");

            migrationBuilder.DropColumn(
                name: "ModifiedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "MessageActions");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "MessageActionOptions");

            migrationBuilder.DropColumn(
                name: "CreatedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "MessageActionOptions");

            migrationBuilder.DropColumn(
                name: "Guid",
                schema: "ShoukouhPardis12DBAdmin",
                table: "MessageActionOptions");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "ShoukouhPardis12DBAdmin",
                table: "MessageActionOptions");

            migrationBuilder.DropColumn(
                name: "ModifiedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "MessageActionOptions");

            migrationBuilder.DropColumn(
                name: "ModifiedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "MessageActionOptions");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "AdvanceRegistrations");

            migrationBuilder.DropColumn(
                name: "CreatedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "AdvanceRegistrations");

            migrationBuilder.DropColumn(
                name: "Guid",
                schema: "ShoukouhPardis12DBAdmin",
                table: "AdvanceRegistrations");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "ShoukouhPardis12DBAdmin",
                table: "AdvanceRegistrations");

            migrationBuilder.DropColumn(
                name: "ModifiedByUserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "AdvanceRegistrations");

            migrationBuilder.DropColumn(
                name: "ModifiedWhen",
                schema: "ShoukouhPardis12DBAdmin",
                table: "AdvanceRegistrations");
        }
    }
}
