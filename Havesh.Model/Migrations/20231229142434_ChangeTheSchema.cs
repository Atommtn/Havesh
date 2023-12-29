using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Havesh.Model.Migrations
{
    /// <inheritdoc />
    public partial class ChangeTheSchema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "Widgets",
                schema: "ShoukouhPardis12DBAdmin",
                newName: "Widgets",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "WidgetGroup",
                schema: "ShoukouhPardis12DBAdmin",
                newName: "WidgetGroup",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "Users",
                schema: "ShoukouhPardis12DBAdmin",
                newName: "Users",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "StatementParsianM",
                schema: "ShoukouhPardis12DBAdmin",
                newName: "StatementParsianM",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "StatementMeliN",
                schema: "ShoukouhPardis12DBAdmin",
                newName: "StatementMeliN",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "ShokouhPardis_TimeTableStudents",
                schema: "ShoukouhPardis12DBAdmin",
                newName: "ShokouhPardis_TimeTableStudents",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "ShokouhPardis_TimeTableSession",
                schema: "ShoukouhPardis12DBAdmin",
                newName: "ShokouhPardis_TimeTableSession",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "ShokouhPardis_TimeTable",
                schema: "ShoukouhPardis12DBAdmin",
                newName: "ShokouhPardis_TimeTable",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "ShokouhPardis_TermSessionTemplateDate",
                schema: "ShoukouhPardis12DBAdmin",
                newName: "ShokouhPardis_TermSessionTemplateDate",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "ShokouhPardis_TermSessionTemplate",
                schema: "ShoukouhPardis12DBAdmin",
                newName: "ShokouhPardis_TermSessionTemplate",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "ShokouhPardis_TeacherTimeSheet",
                schema: "ShoukouhPardis12DBAdmin",
                newName: "ShokouhPardis_TeacherTimeSheet",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "ShokouhPardis_TeacherTermClass",
                schema: "ShoukouhPardis12DBAdmin",
                newName: "ShokouhPardis_TeacherTermClass",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "ShokouhPardis_TeacherLevels",
                schema: "ShoukouhPardis12DBAdmin",
                newName: "ShokouhPardis_TeacherLevels",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "ShokouhPardis_StudentSessionActivity",
                schema: "ShoukouhPardis12DBAdmin",
                newName: "ShokouhPardis_StudentSessionActivity",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "ShokouhPardis_StudentClass_OnlineForm",
                schema: "ShoukouhPardis12DBAdmin",
                newName: "ShokouhPardis_StudentClass_OnlineForm",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "ShokouhPardis_StudentClass_Dto",
                schema: "ShoukouhPardis12DBAdmin",
                newName: "ShokouhPardis_StudentClass_Dto",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "ShokouhPardis_SessionActivityValueOption",
                schema: "ShoukouhPardis12DBAdmin",
                newName: "ShokouhPardis_SessionActivityValueOption",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "ShokouhPardis_SessionActivity",
                schema: "ShoukouhPardis12DBAdmin",
                newName: "ShokouhPardis_SessionActivity",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "ShokouhPardis_PreRegistration",
                schema: "ShoukouhPardis12DBAdmin",
                newName: "ShokouhPardis_PreRegistration",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "ShokouhPardis_MediaAttachment",
                schema: "ShoukouhPardis12DBAdmin",
                newName: "ShokouhPardis_MediaAttachment",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "ShokouhPardis_LevelBookPrice",
                schema: "ShoukouhPardis12DBAdmin",
                newName: "ShokouhPardis_LevelBookPrice",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "ShokouhPardis_LessonPlanSectionType",
                schema: "ShoukouhPardis12DBAdmin",
                newName: "ShokouhPardis_LessonPlanSectionType",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "ShokouhPardis_LessonPlanSectionItem",
                schema: "ShoukouhPardis12DBAdmin",
                newName: "ShokouhPardis_LessonPlanSectionItem",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "ShokouhPardis_LessonPlanSection",
                schema: "ShoukouhPardis12DBAdmin",
                newName: "ShokouhPardis_LessonPlanSection",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "ShokouhPardis_LessonPlanAttachments",
                schema: "ShoukouhPardis12DBAdmin",
                newName: "ShokouhPardis_LessonPlanAttachments",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "ShokouhPardis_LessonPlan",
                schema: "ShoukouhPardis12DBAdmin",
                newName: "ShokouhPardis_LessonPlan",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "ShokouhPardis_JVFromSite",
                schema: "ShoukouhPardis12DBAdmin",
                newName: "ShokouhPardis_JVFromSite",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "ShokouhPardis_Finance_Flat",
                schema: "ShoukouhPardis12DBAdmin",
                newName: "ShokouhPardis_Finance_Flat",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "ShokouhPardis_FileAttachment",
                schema: "ShoukouhPardis12DBAdmin",
                newName: "ShokouhPardis_FileAttachment",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "ShokouhPardis_Employee",
                schema: "ShoukouhPardis12DBAdmin",
                newName: "ShokouhPardis_Employee",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "ShokouhPardis_DailyJV",
                schema: "ShoukouhPardis12DBAdmin",
                newName: "ShokouhPardis_DailyJV",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "ShokouhPardis_AccountingTransaction",
                schema: "ShoukouhPardis12DBAdmin",
                newName: "ShokouhPardis_AccountingTransaction",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "ShokouhPardis_AccountingCode",
                schema: "ShoukouhPardis12DBAdmin",
                newName: "ShokouhPardis_AccountingCode",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "RoleUser",
                schema: "ShoukouhPardis12DBAdmin",
                newName: "RoleUser",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "Roles",
                schema: "ShoukouhPardis12DBAdmin",
                newName: "Roles",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "Permissions",
                schema: "ShoukouhPardis12DBAdmin",
                newName: "Permissions",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "PermissionRole",
                schema: "ShoukouhPardis12DBAdmin",
                newName: "PermissionRole",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "Messages",
                schema: "ShoukouhPardis12DBAdmin",
                newName: "Messages",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "MessageBoxes",
                schema: "ShoukouhPardis12DBAdmin",
                newName: "MessageBoxes",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "MessageActions",
                schema: "ShoukouhPardis12DBAdmin",
                newName: "MessageActions",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "MessageActionOptions",
                schema: "ShoukouhPardis12DBAdmin",
                newName: "MessageActionOptions",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "EntityChanges",
                schema: "ShoukouhPardis12DBAdmin",
                newName: "EntityChanges",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "DashboardWidgetSettings",
                schema: "ShoukouhPardis12DBAdmin",
                newName: "DashboardWidgetSettings",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "DashboardTemplateWidgets",
                schema: "ShoukouhPardis12DBAdmin",
                newName: "DashboardTemplateWidgets",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "DashboardTemplates",
                schema: "ShoukouhPardis12DBAdmin",
                newName: "DashboardTemplates",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "Dashboards",
                schema: "ShoukouhPardis12DBAdmin",
                newName: "Dashboards",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "ApplicationSettingsCategory",
                schema: "ShoukouhPardis12DBAdmin",
                newName: "ApplicationSettingsCategory",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "ApplicationSettings",
                schema: "ShoukouhPardis12DBAdmin",
                newName: "ApplicationSettings",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "AppBranch",
                schema: "ShoukouhPardis12DBAdmin",
                newName: "AppBranch",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "AdvanceRegistrations",
                schema: "ShoukouhPardis12DBAdmin",
                newName: "AdvanceRegistrations",
                newSchema: "dbo");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "ShoukouhPardis12DBAdmin");

            migrationBuilder.RenameTable(
                name: "Widgets",
                schema: "dbo",
                newName: "Widgets",
                newSchema: "ShoukouhPardis12DBAdmin");

            migrationBuilder.RenameTable(
                name: "WidgetGroup",
                schema: "dbo",
                newName: "WidgetGroup",
                newSchema: "ShoukouhPardis12DBAdmin");

            migrationBuilder.RenameTable(
                name: "Users",
                schema: "dbo",
                newName: "Users",
                newSchema: "ShoukouhPardis12DBAdmin");

            migrationBuilder.RenameTable(
                name: "StatementParsianM",
                schema: "dbo",
                newName: "StatementParsianM",
                newSchema: "ShoukouhPardis12DBAdmin");

            migrationBuilder.RenameTable(
                name: "StatementMeliN",
                schema: "dbo",
                newName: "StatementMeliN",
                newSchema: "ShoukouhPardis12DBAdmin");

            migrationBuilder.RenameTable(
                name: "ShokouhPardis_TimeTableStudents",
                schema: "dbo",
                newName: "ShokouhPardis_TimeTableStudents",
                newSchema: "ShoukouhPardis12DBAdmin");

            migrationBuilder.RenameTable(
                name: "ShokouhPardis_TimeTableSession",
                schema: "dbo",
                newName: "ShokouhPardis_TimeTableSession",
                newSchema: "ShoukouhPardis12DBAdmin");

            migrationBuilder.RenameTable(
                name: "ShokouhPardis_TimeTable",
                schema: "dbo",
                newName: "ShokouhPardis_TimeTable",
                newSchema: "ShoukouhPardis12DBAdmin");

            migrationBuilder.RenameTable(
                name: "ShokouhPardis_TermSessionTemplateDate",
                schema: "dbo",
                newName: "ShokouhPardis_TermSessionTemplateDate",
                newSchema: "ShoukouhPardis12DBAdmin");

            migrationBuilder.RenameTable(
                name: "ShokouhPardis_TermSessionTemplate",
                schema: "dbo",
                newName: "ShokouhPardis_TermSessionTemplate",
                newSchema: "ShoukouhPardis12DBAdmin");

            migrationBuilder.RenameTable(
                name: "ShokouhPardis_TeacherTimeSheet",
                schema: "dbo",
                newName: "ShokouhPardis_TeacherTimeSheet",
                newSchema: "ShoukouhPardis12DBAdmin");

            migrationBuilder.RenameTable(
                name: "ShokouhPardis_TeacherTermClass",
                schema: "dbo",
                newName: "ShokouhPardis_TeacherTermClass",
                newSchema: "ShoukouhPardis12DBAdmin");

            migrationBuilder.RenameTable(
                name: "ShokouhPardis_TeacherLevels",
                schema: "dbo",
                newName: "ShokouhPardis_TeacherLevels",
                newSchema: "ShoukouhPardis12DBAdmin");

            migrationBuilder.RenameTable(
                name: "ShokouhPardis_StudentSessionActivity",
                schema: "dbo",
                newName: "ShokouhPardis_StudentSessionActivity",
                newSchema: "ShoukouhPardis12DBAdmin");

            migrationBuilder.RenameTable(
                name: "ShokouhPardis_StudentClass_OnlineForm",
                schema: "dbo",
                newName: "ShokouhPardis_StudentClass_OnlineForm",
                newSchema: "ShoukouhPardis12DBAdmin");

            migrationBuilder.RenameTable(
                name: "ShokouhPardis_StudentClass_Dto",
                schema: "dbo",
                newName: "ShokouhPardis_StudentClass_Dto",
                newSchema: "ShoukouhPardis12DBAdmin");

            migrationBuilder.RenameTable(
                name: "ShokouhPardis_SessionActivityValueOption",
                schema: "dbo",
                newName: "ShokouhPardis_SessionActivityValueOption",
                newSchema: "ShoukouhPardis12DBAdmin");

            migrationBuilder.RenameTable(
                name: "ShokouhPardis_SessionActivity",
                schema: "dbo",
                newName: "ShokouhPardis_SessionActivity",
                newSchema: "ShoukouhPardis12DBAdmin");

            migrationBuilder.RenameTable(
                name: "ShokouhPardis_PreRegistration",
                schema: "dbo",
                newName: "ShokouhPardis_PreRegistration",
                newSchema: "ShoukouhPardis12DBAdmin");

            migrationBuilder.RenameTable(
                name: "ShokouhPardis_MediaAttachment",
                schema: "dbo",
                newName: "ShokouhPardis_MediaAttachment",
                newSchema: "ShoukouhPardis12DBAdmin");

            migrationBuilder.RenameTable(
                name: "ShokouhPardis_LevelBookPrice",
                schema: "dbo",
                newName: "ShokouhPardis_LevelBookPrice",
                newSchema: "ShoukouhPardis12DBAdmin");

            migrationBuilder.RenameTable(
                name: "ShokouhPardis_LessonPlanSectionType",
                schema: "dbo",
                newName: "ShokouhPardis_LessonPlanSectionType",
                newSchema: "ShoukouhPardis12DBAdmin");

            migrationBuilder.RenameTable(
                name: "ShokouhPardis_LessonPlanSectionItem",
                schema: "dbo",
                newName: "ShokouhPardis_LessonPlanSectionItem",
                newSchema: "ShoukouhPardis12DBAdmin");

            migrationBuilder.RenameTable(
                name: "ShokouhPardis_LessonPlanSection",
                schema: "dbo",
                newName: "ShokouhPardis_LessonPlanSection",
                newSchema: "ShoukouhPardis12DBAdmin");

            migrationBuilder.RenameTable(
                name: "ShokouhPardis_LessonPlanAttachments",
                schema: "dbo",
                newName: "ShokouhPardis_LessonPlanAttachments",
                newSchema: "ShoukouhPardis12DBAdmin");

            migrationBuilder.RenameTable(
                name: "ShokouhPardis_LessonPlan",
                schema: "dbo",
                newName: "ShokouhPardis_LessonPlan",
                newSchema: "ShoukouhPardis12DBAdmin");

            migrationBuilder.RenameTable(
                name: "ShokouhPardis_JVFromSite",
                schema: "dbo",
                newName: "ShokouhPardis_JVFromSite",
                newSchema: "ShoukouhPardis12DBAdmin");

            migrationBuilder.RenameTable(
                name: "ShokouhPardis_Finance_Flat",
                schema: "dbo",
                newName: "ShokouhPardis_Finance_Flat",
                newSchema: "ShoukouhPardis12DBAdmin");

            migrationBuilder.RenameTable(
                name: "ShokouhPardis_FileAttachment",
                schema: "dbo",
                newName: "ShokouhPardis_FileAttachment",
                newSchema: "ShoukouhPardis12DBAdmin");

            migrationBuilder.RenameTable(
                name: "ShokouhPardis_Employee",
                schema: "dbo",
                newName: "ShokouhPardis_Employee",
                newSchema: "ShoukouhPardis12DBAdmin");

            migrationBuilder.RenameTable(
                name: "ShokouhPardis_DailyJV",
                schema: "dbo",
                newName: "ShokouhPardis_DailyJV",
                newSchema: "ShoukouhPardis12DBAdmin");

            migrationBuilder.RenameTable(
                name: "ShokouhPardis_AccountingTransaction",
                schema: "dbo",
                newName: "ShokouhPardis_AccountingTransaction",
                newSchema: "ShoukouhPardis12DBAdmin");

            migrationBuilder.RenameTable(
                name: "ShokouhPardis_AccountingCode",
                schema: "dbo",
                newName: "ShokouhPardis_AccountingCode",
                newSchema: "ShoukouhPardis12DBAdmin");

            migrationBuilder.RenameTable(
                name: "RoleUser",
                schema: "dbo",
                newName: "RoleUser",
                newSchema: "ShoukouhPardis12DBAdmin");

            migrationBuilder.RenameTable(
                name: "Roles",
                schema: "dbo",
                newName: "Roles",
                newSchema: "ShoukouhPardis12DBAdmin");

            migrationBuilder.RenameTable(
                name: "Permissions",
                schema: "dbo",
                newName: "Permissions",
                newSchema: "ShoukouhPardis12DBAdmin");

            migrationBuilder.RenameTable(
                name: "PermissionRole",
                schema: "dbo",
                newName: "PermissionRole",
                newSchema: "ShoukouhPardis12DBAdmin");

            migrationBuilder.RenameTable(
                name: "Messages",
                schema: "dbo",
                newName: "Messages",
                newSchema: "ShoukouhPardis12DBAdmin");

            migrationBuilder.RenameTable(
                name: "MessageBoxes",
                schema: "dbo",
                newName: "MessageBoxes",
                newSchema: "ShoukouhPardis12DBAdmin");

            migrationBuilder.RenameTable(
                name: "MessageActions",
                schema: "dbo",
                newName: "MessageActions",
                newSchema: "ShoukouhPardis12DBAdmin");

            migrationBuilder.RenameTable(
                name: "MessageActionOptions",
                schema: "dbo",
                newName: "MessageActionOptions",
                newSchema: "ShoukouhPardis12DBAdmin");

            migrationBuilder.RenameTable(
                name: "EntityChanges",
                schema: "dbo",
                newName: "EntityChanges",
                newSchema: "ShoukouhPardis12DBAdmin");

            migrationBuilder.RenameTable(
                name: "DashboardWidgetSettings",
                schema: "dbo",
                newName: "DashboardWidgetSettings",
                newSchema: "ShoukouhPardis12DBAdmin");

            migrationBuilder.RenameTable(
                name: "DashboardTemplateWidgets",
                schema: "dbo",
                newName: "DashboardTemplateWidgets",
                newSchema: "ShoukouhPardis12DBAdmin");

            migrationBuilder.RenameTable(
                name: "DashboardTemplates",
                schema: "dbo",
                newName: "DashboardTemplates",
                newSchema: "ShoukouhPardis12DBAdmin");

            migrationBuilder.RenameTable(
                name: "Dashboards",
                schema: "dbo",
                newName: "Dashboards",
                newSchema: "ShoukouhPardis12DBAdmin");

            migrationBuilder.RenameTable(
                name: "ApplicationSettingsCategory",
                schema: "dbo",
                newName: "ApplicationSettingsCategory",
                newSchema: "ShoukouhPardis12DBAdmin");

            migrationBuilder.RenameTable(
                name: "ApplicationSettings",
                schema: "dbo",
                newName: "ApplicationSettings",
                newSchema: "ShoukouhPardis12DBAdmin");

            migrationBuilder.RenameTable(
                name: "AppBranch",
                schema: "dbo",
                newName: "AppBranch",
                newSchema: "ShoukouhPardis12DBAdmin");

            migrationBuilder.RenameTable(
                name: "AdvanceRegistrations",
                schema: "dbo",
                newName: "AdvanceRegistrations",
                newSchema: "ShoukouhPardis12DBAdmin");
        }
    }
}
