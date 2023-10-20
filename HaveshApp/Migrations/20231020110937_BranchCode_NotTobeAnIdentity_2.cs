using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HaveshApp.Migrations
{
    /// <inheritdoc />
    public partial class BranchCode_NotTobeAnIdentity_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShokouhPardis_AccountingCode_Branch_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_AccountingCode");

            migrationBuilder.DropForeignKey(
                name: "FK_ShokouhPardis_AccountingTransaction_Branch_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_AccountingTransaction");

            migrationBuilder.DropForeignKey(
                name: "FK_ShokouhPardis_BookClass_Branch_BranchFk",
                schema: "dbo",
                table: "ShokouhPardis_BookClass");

            migrationBuilder.DropForeignKey(
                name: "FK_ShokouhPardis_ClassRoom_Branch_BranchFk",
                schema: "dbo",
                table: "ShokouhPardis_ClassRoom");

            migrationBuilder.DropForeignKey(
                name: "FK_ShokouhPardis_DailyJV_Branch_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_DailyJV");

            migrationBuilder.DropForeignKey(
                name: "FK_ShokouhPardis_DaySession_Branch_BranchFk",
                schema: "dbo",
                table: "ShokouhPardis_DaySession");

            migrationBuilder.DropForeignKey(
                name: "FK_ShokouhPardis_Employee_Branch_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_Employee");

            migrationBuilder.DropForeignKey(
                name: "FK_ShokouhPardis_FileAttachment_Branch_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_FileAttachment");

            migrationBuilder.DropForeignKey(
                name: "FK_ShokouhPardis_Finance_Flat_Branch_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_Finance_Flat");

            migrationBuilder.DropForeignKey(
                name: "FK_ShokouhPardis_Interval_Branch_BranchFk",
                schema: "dbo",
                table: "ShokouhPardis_Interval");

            migrationBuilder.DropForeignKey(
                name: "FK_ShokouhPardis_JVFromSite_Branch_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_JVFromSite");

            migrationBuilder.DropForeignKey(
                name: "FK_ShokouhPardis_LessonPlan_Branch_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_LessonPlan");

            migrationBuilder.DropForeignKey(
                name: "FK_ShokouhPardis_LessonPlanSection_Branch_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_LessonPlanSection");

            migrationBuilder.DropForeignKey(
                name: "FK_ShokouhPardis_LessonPlanSectionType_Branch_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_LessonPlanSectionType");

            migrationBuilder.DropForeignKey(
                name: "FK_ShokouhPardis_LevelBookPrice_Branch_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_LevelBookPrice");

            migrationBuilder.DropForeignKey(
                name: "FK_ShokouhPardis_LevelClass_Branch_BranchFk",
                schema: "dbo",
                table: "ShokouhPardis_LevelClass");

            migrationBuilder.DropForeignKey(
                name: "FK_ShokouhPardis_MediaAttachment_Branch_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_MediaAttachment");

            migrationBuilder.DropForeignKey(
                name: "FK_ShokouhPardis_PreRegistration_Branch_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_PreRegistration");

            migrationBuilder.DropForeignKey(
                name: "FK_ShokouhPardis_schedule_Branch_BranchFk",
                schema: "dbo",
                table: "ShokouhPardis_schedule");

            migrationBuilder.DropForeignKey(
                name: "FK_ShokouhPardis_SessionActivity_Branch_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_SessionActivity");

            migrationBuilder.DropForeignKey(
                name: "FK_ShokouhPardis_StudentClass_Branch_BranchFk",
                schema: "dbo",
                table: "ShokouhPardis_StudentClass");

            migrationBuilder.DropForeignKey(
                name: "FK_ShokouhPardis_StudentClass_Dto_Branch_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_StudentClass_Dto");

            migrationBuilder.DropForeignKey(
                name: "FK_ShokouhPardis_StudentClass_OnlineForm_Branch_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_StudentClass_OnlineForm");

            migrationBuilder.DropForeignKey(
                name: "FK_ShokouhPardis_StudentSessionActivity_Branch_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_StudentSessionActivity");

            migrationBuilder.DropForeignKey(
                name: "FK_ShokouhPardis_TeacherClass_Branch_BranchFk",
                schema: "dbo",
                table: "ShokouhPardis_TeacherClass");

            migrationBuilder.DropForeignKey(
                name: "FK_ShokouhPardis_TeacherLevels_Branch_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TeacherLevels");

            migrationBuilder.DropForeignKey(
                name: "FK_ShokouhPardis_TeacherTermClass_Branch_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TeacherTermClass");

            migrationBuilder.DropForeignKey(
                name: "FK_ShokouhPardis_TeacherTimeSheet_Branch_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TeacherTimeSheet");

            migrationBuilder.DropForeignKey(
                name: "FK_ShokouhPardis_TermClass_Branch_BranchFk",
                schema: "dbo",
                table: "ShokouhPardis_TermClass");

            migrationBuilder.DropForeignKey(
                name: "FK_ShokouhPardis_TermSessionTemplate_Branch_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TermSessionTemplate");

            migrationBuilder.DropForeignKey(
                name: "FK_ShokouhPardis_TermSessionTemplateDate_Branch_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TermSessionTemplateDate");

            migrationBuilder.DropForeignKey(
                name: "FK_ShokouhPardis_TimeTable_Branch_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TimeTable");

            migrationBuilder.DropForeignKey(
                name: "FK_ShokouhPardis_TimeTableSession_Branch_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TimeTableSession");

            migrationBuilder.DropForeignKey(
                name: "FK_ShokouhPardis_TimeTableStudents_Branch_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TimeTableStudents");

            /*
            migrationBuilder.DropPrimaryKey(
                name: "PK_Branch",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Branch");

            migrationBuilder.RenameTable(
                name: "Branch",
                schema: "ShoukouhPardis12DBAdmin",
                newName: "AppBranch",
                newSchema: "ShoukouhPardis12DBAdmin");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppBranch",
                schema: "ShoukouhPardis12DBAdmin",
                table: "AppBranch",
                column: "Id");
                */

            migrationBuilder.AddForeignKey(
                name: "FK_ShokouhPardis_AccountingCode_AppBranch_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_AccountingCode",
                column: "BranchFk",
                principalSchema: "ShoukouhPardis12DBAdmin",
                principalTable: "AppBranch",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_ShokouhPardis_AccountingTransaction_AppBranch_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_AccountingTransaction",
                column: "BranchFk",
                principalSchema: "ShoukouhPardis12DBAdmin",
                principalTable: "AppBranch",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_ShokouhPardis_BookClass_AppBranch_BranchFk",
                schema: "dbo",
                table: "ShokouhPardis_BookClass",
                column: "BranchFk",
                principalSchema: "ShoukouhPardis12DBAdmin",
                principalTable: "AppBranch",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_ShokouhPardis_ClassRoom_AppBranch_BranchFk",
                schema: "dbo",
                table: "ShokouhPardis_ClassRoom",
                column: "BranchFk",
                principalSchema: "ShoukouhPardis12DBAdmin",
                principalTable: "AppBranch",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_ShokouhPardis_DailyJV_AppBranch_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_DailyJV",
                column: "BranchFk",
                principalSchema: "ShoukouhPardis12DBAdmin",
                principalTable: "AppBranch",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_ShokouhPardis_DaySession_AppBranch_BranchFk",
                schema: "dbo",
                table: "ShokouhPardis_DaySession",
                column: "BranchFk",
                principalSchema: "ShoukouhPardis12DBAdmin",
                principalTable: "AppBranch",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_ShokouhPardis_Employee_AppBranch_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_Employee",
                column: "BranchFk",
                principalSchema: "ShoukouhPardis12DBAdmin",
                principalTable: "AppBranch",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_ShokouhPardis_FileAttachment_AppBranch_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_FileAttachment",
                column: "BranchFk",
                principalSchema: "ShoukouhPardis12DBAdmin",
                principalTable: "AppBranch",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_ShokouhPardis_Finance_Flat_AppBranch_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_Finance_Flat",
                column: "BranchFk",
                principalSchema: "ShoukouhPardis12DBAdmin",
                principalTable: "AppBranch",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_ShokouhPardis_Interval_AppBranch_BranchFk",
                schema: "dbo",
                table: "ShokouhPardis_Interval",
                column: "BranchFk",
                principalSchema: "ShoukouhPardis12DBAdmin",
                principalTable: "AppBranch",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_ShokouhPardis_JVFromSite_AppBranch_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_JVFromSite",
                column: "BranchFk",
                principalSchema: "ShoukouhPardis12DBAdmin",
                principalTable: "AppBranch",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_ShokouhPardis_LessonPlan_AppBranch_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_LessonPlan",
                column: "BranchFk",
                principalSchema: "ShoukouhPardis12DBAdmin",
                principalTable: "AppBranch",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_ShokouhPardis_LessonPlanSection_AppBranch_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_LessonPlanSection",
                column: "BranchFk",
                principalSchema: "ShoukouhPardis12DBAdmin",
                principalTable: "AppBranch",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_ShokouhPardis_LessonPlanSectionType_AppBranch_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_LessonPlanSectionType",
                column: "BranchFk",
                principalSchema: "ShoukouhPardis12DBAdmin",
                principalTable: "AppBranch",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_ShokouhPardis_LevelBookPrice_AppBranch_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_LevelBookPrice",
                column: "BranchFk",
                principalSchema: "ShoukouhPardis12DBAdmin",
                principalTable: "AppBranch",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_ShokouhPardis_LevelClass_AppBranch_BranchFk",
                schema: "dbo",
                table: "ShokouhPardis_LevelClass",
                column: "BranchFk",
                principalSchema: "ShoukouhPardis12DBAdmin",
                principalTable: "AppBranch",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_ShokouhPardis_MediaAttachment_AppBranch_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_MediaAttachment",
                column: "BranchFk",
                principalSchema: "ShoukouhPardis12DBAdmin",
                principalTable: "AppBranch",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_ShokouhPardis_PreRegistration_AppBranch_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_PreRegistration",
                column: "BranchFk",
                principalSchema: "ShoukouhPardis12DBAdmin",
                principalTable: "AppBranch",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_ShokouhPardis_schedule_AppBranch_BranchFk",
                schema: "dbo",
                table: "ShokouhPardis_schedule",
                column: "BranchFk",
                principalSchema: "ShoukouhPardis12DBAdmin",
                principalTable: "AppBranch",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_ShokouhPardis_SessionActivity_AppBranch_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_SessionActivity",
                column: "BranchFk",
                principalSchema: "ShoukouhPardis12DBAdmin",
                principalTable: "AppBranch",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_ShokouhPardis_StudentClass_AppBranch_BranchFk",
                schema: "dbo",
                table: "ShokouhPardis_StudentClass",
                column: "BranchFk",
                principalSchema: "ShoukouhPardis12DBAdmin",
                principalTable: "AppBranch",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_ShokouhPardis_StudentClass_Dto_AppBranch_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_StudentClass_Dto",
                column: "BranchFk",
                principalSchema: "ShoukouhPardis12DBAdmin",
                principalTable: "AppBranch",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_ShokouhPardis_StudentClass_OnlineForm_AppBranch_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_StudentClass_OnlineForm",
                column: "BranchFk",
                principalSchema: "ShoukouhPardis12DBAdmin",
                principalTable: "AppBranch",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_ShokouhPardis_StudentSessionActivity_AppBranch_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_StudentSessionActivity",
                column: "BranchFk",
                principalSchema: "ShoukouhPardis12DBAdmin",
                principalTable: "AppBranch",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_ShokouhPardis_TeacherClass_AppBranch_BranchFk",
                schema: "dbo",
                table: "ShokouhPardis_TeacherClass",
                column: "BranchFk",
                principalSchema: "ShoukouhPardis12DBAdmin",
                principalTable: "AppBranch",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_ShokouhPardis_TeacherLevels_AppBranch_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TeacherLevels",
                column: "BranchFk",
                principalSchema: "ShoukouhPardis12DBAdmin",
                principalTable: "AppBranch",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_ShokouhPardis_TeacherTermClass_AppBranch_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TeacherTermClass",
                column: "BranchFk",
                principalSchema: "ShoukouhPardis12DBAdmin",
                principalTable: "AppBranch",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_ShokouhPardis_TeacherTimeSheet_AppBranch_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TeacherTimeSheet",
                column: "BranchFk",
                principalSchema: "ShoukouhPardis12DBAdmin",
                principalTable: "AppBranch",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_ShokouhPardis_TermClass_AppBranch_BranchFk",
                schema: "dbo",
                table: "ShokouhPardis_TermClass",
                column: "BranchFk",
                principalSchema: "ShoukouhPardis12DBAdmin",
                principalTable: "AppBranch",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_ShokouhPardis_TermSessionTemplate_AppBranch_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TermSessionTemplate",
                column: "BranchFk",
                principalSchema: "ShoukouhPardis12DBAdmin",
                principalTable: "AppBranch",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_ShokouhPardis_TermSessionTemplateDate_AppBranch_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TermSessionTemplateDate",
                column: "BranchFk",
                principalSchema: "ShoukouhPardis12DBAdmin",
                principalTable: "AppBranch",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_ShokouhPardis_TimeTable_AppBranch_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TimeTable",
                column: "BranchFk",
                principalSchema: "ShoukouhPardis12DBAdmin",
                principalTable: "AppBranch",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_ShokouhPardis_TimeTableSession_AppBranch_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TimeTableSession",
                column: "BranchFk",
                principalSchema: "ShoukouhPardis12DBAdmin",
                principalTable: "AppBranch",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_ShokouhPardis_TimeTableStudents_AppBranch_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TimeTableStudents",
                column: "BranchFk",
                principalSchema: "ShoukouhPardis12DBAdmin",
                principalTable: "AppBranch",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShokouhPardis_AccountingCode_AppBranch_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_AccountingCode");

            migrationBuilder.DropForeignKey(
                name: "FK_ShokouhPardis_AccountingTransaction_AppBranch_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_AccountingTransaction");

            migrationBuilder.DropForeignKey(
                name: "FK_ShokouhPardis_BookClass_AppBranch_BranchFk",
                schema: "dbo",
                table: "ShokouhPardis_BookClass");

            migrationBuilder.DropForeignKey(
                name: "FK_ShokouhPardis_ClassRoom_AppBranch_BranchFk",
                schema: "dbo",
                table: "ShokouhPardis_ClassRoom");

            migrationBuilder.DropForeignKey(
                name: "FK_ShokouhPardis_DailyJV_AppBranch_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_DailyJV");

            migrationBuilder.DropForeignKey(
                name: "FK_ShokouhPardis_DaySession_AppBranch_BranchFk",
                schema: "dbo",
                table: "ShokouhPardis_DaySession");

            migrationBuilder.DropForeignKey(
                name: "FK_ShokouhPardis_Employee_AppBranch_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_Employee");

            migrationBuilder.DropForeignKey(
                name: "FK_ShokouhPardis_FileAttachment_AppBranch_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_FileAttachment");

            migrationBuilder.DropForeignKey(
                name: "FK_ShokouhPardis_Finance_Flat_AppBranch_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_Finance_Flat");

            migrationBuilder.DropForeignKey(
                name: "FK_ShokouhPardis_Interval_AppBranch_BranchFk",
                schema: "dbo",
                table: "ShokouhPardis_Interval");

            migrationBuilder.DropForeignKey(
                name: "FK_ShokouhPardis_JVFromSite_AppBranch_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_JVFromSite");

            migrationBuilder.DropForeignKey(
                name: "FK_ShokouhPardis_LessonPlan_AppBranch_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_LessonPlan");

            migrationBuilder.DropForeignKey(
                name: "FK_ShokouhPardis_LessonPlanSection_AppBranch_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_LessonPlanSection");

            migrationBuilder.DropForeignKey(
                name: "FK_ShokouhPardis_LessonPlanSectionType_AppBranch_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_LessonPlanSectionType");

            migrationBuilder.DropForeignKey(
                name: "FK_ShokouhPardis_LevelBookPrice_AppBranch_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_LevelBookPrice");

            migrationBuilder.DropForeignKey(
                name: "FK_ShokouhPardis_LevelClass_AppBranch_BranchFk",
                schema: "dbo",
                table: "ShokouhPardis_LevelClass");

            migrationBuilder.DropForeignKey(
                name: "FK_ShokouhPardis_MediaAttachment_AppBranch_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_MediaAttachment");

            migrationBuilder.DropForeignKey(
                name: "FK_ShokouhPardis_PreRegistration_AppBranch_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_PreRegistration");

            migrationBuilder.DropForeignKey(
                name: "FK_ShokouhPardis_schedule_AppBranch_BranchFk",
                schema: "dbo",
                table: "ShokouhPardis_schedule");

            migrationBuilder.DropForeignKey(
                name: "FK_ShokouhPardis_SessionActivity_AppBranch_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_SessionActivity");

            migrationBuilder.DropForeignKey(
                name: "FK_ShokouhPardis_StudentClass_AppBranch_BranchFk",
                schema: "dbo",
                table: "ShokouhPardis_StudentClass");

            migrationBuilder.DropForeignKey(
                name: "FK_ShokouhPardis_StudentClass_Dto_AppBranch_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_StudentClass_Dto");

            migrationBuilder.DropForeignKey(
                name: "FK_ShokouhPardis_StudentClass_OnlineForm_AppBranch_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_StudentClass_OnlineForm");

            migrationBuilder.DropForeignKey(
                name: "FK_ShokouhPardis_StudentSessionActivity_AppBranch_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_StudentSessionActivity");

            migrationBuilder.DropForeignKey(
                name: "FK_ShokouhPardis_TeacherClass_AppBranch_BranchFk",
                schema: "dbo",
                table: "ShokouhPardis_TeacherClass");

            migrationBuilder.DropForeignKey(
                name: "FK_ShokouhPardis_TeacherLevels_AppBranch_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TeacherLevels");

            migrationBuilder.DropForeignKey(
                name: "FK_ShokouhPardis_TeacherTermClass_AppBranch_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TeacherTermClass");

            migrationBuilder.DropForeignKey(
                name: "FK_ShokouhPardis_TeacherTimeSheet_AppBranch_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TeacherTimeSheet");

            migrationBuilder.DropForeignKey(
                name: "FK_ShokouhPardis_TermClass_AppBranch_BranchFk",
                schema: "dbo",
                table: "ShokouhPardis_TermClass");

            migrationBuilder.DropForeignKey(
                name: "FK_ShokouhPardis_TermSessionTemplate_AppBranch_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TermSessionTemplate");

            migrationBuilder.DropForeignKey(
                name: "FK_ShokouhPardis_TermSessionTemplateDate_AppBranch_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TermSessionTemplateDate");

            migrationBuilder.DropForeignKey(
                name: "FK_ShokouhPardis_TimeTable_AppBranch_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TimeTable");

            migrationBuilder.DropForeignKey(
                name: "FK_ShokouhPardis_TimeTableSession_AppBranch_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TimeTableSession");

            migrationBuilder.DropForeignKey(
                name: "FK_ShokouhPardis_TimeTableStudents_AppBranch_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TimeTableStudents");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppBranch",
                schema: "ShoukouhPardis12DBAdmin",
                table: "AppBranch");

            migrationBuilder.RenameTable(
                name: "AppBranch",
                schema: "ShoukouhPardis12DBAdmin",
                newName: "Branch",
                newSchema: "ShoukouhPardis12DBAdmin");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Branch",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Branch",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ShokouhPardis_AccountingCode_Branch_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_AccountingCode",
                column: "BranchFk",
                principalSchema: "ShoukouhPardis12DBAdmin",
                principalTable: "Branch",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_ShokouhPardis_AccountingTransaction_Branch_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_AccountingTransaction",
                column: "BranchFk",
                principalSchema: "ShoukouhPardis12DBAdmin",
                principalTable: "Branch",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_ShokouhPardis_BookClass_Branch_BranchFk",
                schema: "dbo",
                table: "ShokouhPardis_BookClass",
                column: "BranchFk",
                principalSchema: "ShoukouhPardis12DBAdmin",
                principalTable: "Branch",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_ShokouhPardis_ClassRoom_Branch_BranchFk",
                schema: "dbo",
                table: "ShokouhPardis_ClassRoom",
                column: "BranchFk",
                principalSchema: "ShoukouhPardis12DBAdmin",
                principalTable: "Branch",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_ShokouhPardis_DailyJV_Branch_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_DailyJV",
                column: "BranchFk",
                principalSchema: "ShoukouhPardis12DBAdmin",
                principalTable: "Branch",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_ShokouhPardis_DaySession_Branch_BranchFk",
                schema: "dbo",
                table: "ShokouhPardis_DaySession",
                column: "BranchFk",
                principalSchema: "ShoukouhPardis12DBAdmin",
                principalTable: "Branch",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_ShokouhPardis_Employee_Branch_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_Employee",
                column: "BranchFk",
                principalSchema: "ShoukouhPardis12DBAdmin",
                principalTable: "Branch",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_ShokouhPardis_FileAttachment_Branch_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_FileAttachment",
                column: "BranchFk",
                principalSchema: "ShoukouhPardis12DBAdmin",
                principalTable: "Branch",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_ShokouhPardis_Finance_Flat_Branch_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_Finance_Flat",
                column: "BranchFk",
                principalSchema: "ShoukouhPardis12DBAdmin",
                principalTable: "Branch",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_ShokouhPardis_Interval_Branch_BranchFk",
                schema: "dbo",
                table: "ShokouhPardis_Interval",
                column: "BranchFk",
                principalSchema: "ShoukouhPardis12DBAdmin",
                principalTable: "Branch",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_ShokouhPardis_JVFromSite_Branch_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_JVFromSite",
                column: "BranchFk",
                principalSchema: "ShoukouhPardis12DBAdmin",
                principalTable: "Branch",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_ShokouhPardis_LessonPlan_Branch_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_LessonPlan",
                column: "BranchFk",
                principalSchema: "ShoukouhPardis12DBAdmin",
                principalTable: "Branch",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_ShokouhPardis_LessonPlanSection_Branch_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_LessonPlanSection",
                column: "BranchFk",
                principalSchema: "ShoukouhPardis12DBAdmin",
                principalTable: "Branch",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_ShokouhPardis_LessonPlanSectionType_Branch_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_LessonPlanSectionType",
                column: "BranchFk",
                principalSchema: "ShoukouhPardis12DBAdmin",
                principalTable: "Branch",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_ShokouhPardis_LevelBookPrice_Branch_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_LevelBookPrice",
                column: "BranchFk",
                principalSchema: "ShoukouhPardis12DBAdmin",
                principalTable: "Branch",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_ShokouhPardis_LevelClass_Branch_BranchFk",
                schema: "dbo",
                table: "ShokouhPardis_LevelClass",
                column: "BranchFk",
                principalSchema: "ShoukouhPardis12DBAdmin",
                principalTable: "Branch",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_ShokouhPardis_MediaAttachment_Branch_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_MediaAttachment",
                column: "BranchFk",
                principalSchema: "ShoukouhPardis12DBAdmin",
                principalTable: "Branch",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_ShokouhPardis_PreRegistration_Branch_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_PreRegistration",
                column: "BranchFk",
                principalSchema: "ShoukouhPardis12DBAdmin",
                principalTable: "Branch",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_ShokouhPardis_schedule_Branch_BranchFk",
                schema: "dbo",
                table: "ShokouhPardis_schedule",
                column: "BranchFk",
                principalSchema: "ShoukouhPardis12DBAdmin",
                principalTable: "Branch",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_ShokouhPardis_SessionActivity_Branch_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_SessionActivity",
                column: "BranchFk",
                principalSchema: "ShoukouhPardis12DBAdmin",
                principalTable: "Branch",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_ShokouhPardis_StudentClass_Branch_BranchFk",
                schema: "dbo",
                table: "ShokouhPardis_StudentClass",
                column: "BranchFk",
                principalSchema: "ShoukouhPardis12DBAdmin",
                principalTable: "Branch",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_ShokouhPardis_StudentClass_Dto_Branch_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_StudentClass_Dto",
                column: "BranchFk",
                principalSchema: "ShoukouhPardis12DBAdmin",
                principalTable: "Branch",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_ShokouhPardis_StudentClass_OnlineForm_Branch_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_StudentClass_OnlineForm",
                column: "BranchFk",
                principalSchema: "ShoukouhPardis12DBAdmin",
                principalTable: "Branch",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_ShokouhPardis_StudentSessionActivity_Branch_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_StudentSessionActivity",
                column: "BranchFk",
                principalSchema: "ShoukouhPardis12DBAdmin",
                principalTable: "Branch",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_ShokouhPardis_TeacherClass_Branch_BranchFk",
                schema: "dbo",
                table: "ShokouhPardis_TeacherClass",
                column: "BranchFk",
                principalSchema: "ShoukouhPardis12DBAdmin",
                principalTable: "Branch",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_ShokouhPardis_TeacherLevels_Branch_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TeacherLevels",
                column: "BranchFk",
                principalSchema: "ShoukouhPardis12DBAdmin",
                principalTable: "Branch",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_ShokouhPardis_TeacherTermClass_Branch_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TeacherTermClass",
                column: "BranchFk",
                principalSchema: "ShoukouhPardis12DBAdmin",
                principalTable: "Branch",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_ShokouhPardis_TeacherTimeSheet_Branch_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TeacherTimeSheet",
                column: "BranchFk",
                principalSchema: "ShoukouhPardis12DBAdmin",
                principalTable: "Branch",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_ShokouhPardis_TermClass_Branch_BranchFk",
                schema: "dbo",
                table: "ShokouhPardis_TermClass",
                column: "BranchFk",
                principalSchema: "ShoukouhPardis12DBAdmin",
                principalTable: "Branch",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_ShokouhPardis_TermSessionTemplate_Branch_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TermSessionTemplate",
                column: "BranchFk",
                principalSchema: "ShoukouhPardis12DBAdmin",
                principalTable: "Branch",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_ShokouhPardis_TermSessionTemplateDate_Branch_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TermSessionTemplateDate",
                column: "BranchFk",
                principalSchema: "ShoukouhPardis12DBAdmin",
                principalTable: "Branch",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_ShokouhPardis_TimeTable_Branch_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TimeTable",
                column: "BranchFk",
                principalSchema: "ShoukouhPardis12DBAdmin",
                principalTable: "Branch",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_ShokouhPardis_TimeTableSession_Branch_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TimeTableSession",
                column: "BranchFk",
                principalSchema: "ShoukouhPardis12DBAdmin",
                principalTable: "Branch",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_ShokouhPardis_TimeTableStudents_Branch_BranchFk",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TimeTableStudents",
                column: "BranchFk",
                principalSchema: "ShoukouhPardis12DBAdmin",
                principalTable: "Branch",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }
    }
}
