using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Havesh.Model.Migrations
{
    /// <inheritdoc />
    public partial class EditIds2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LessonPlanId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_LessonPlan",
                newName: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_LessonPlan",
                newName: "LessonPlanId");
        }
    }
}
