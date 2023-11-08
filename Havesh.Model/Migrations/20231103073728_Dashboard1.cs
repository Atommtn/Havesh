using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Havesh.Model.Migrations
{
    /// <inheritdoc />
    public partial class Dashboard1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dashboards",
                schema: "ShoukouhPardis12DBAdmin",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dashboards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dashboards_Users_UserId",
                        column: x => x.UserId,
                        principalSchema: "ShoukouhPardis12DBAdmin",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DashboardTemplates",
                schema: "ShoukouhPardis12DBAdmin",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BelongsToRoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DashboardTemplates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DashboardTemplates_Roles_BelongsToRoleId",
                        column: x => x.BelongsToRoleId,
                        principalSchema: "ShoukouhPardis12DBAdmin",
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Widgets",
                schema: "ShoukouhPardis12DBAdmin",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Order = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TitleClass = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Height = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IconColor = table.Column<int>(type: "int", nullable: true),
                    IconSize = table.Column<int>(type: "int", nullable: true),
                    BreakPoints = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hidden = table.Column<bool>(type: "bit", nullable: true),
                    DashboardId = table.Column<int>(type: "int", nullable: true),
                    DashboardTemplateId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Widgets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Widgets_DashboardTemplates_DashboardTemplateId",
                        column: x => x.DashboardTemplateId,
                        principalSchema: "ShoukouhPardis12DBAdmin",
                        principalTable: "DashboardTemplates",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Widgets_Dashboards_DashboardId",
                        column: x => x.DashboardId,
                        principalSchema: "ShoukouhPardis12DBAdmin",
                        principalTable: "Dashboards",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Dashboards_UserId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Dashboards",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_DashboardTemplates_BelongsToRoleId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "DashboardTemplates",
                column: "BelongsToRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Widgets_DashboardId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Widgets",
                column: "DashboardId");

            migrationBuilder.CreateIndex(
                name: "IX_Widgets_DashboardTemplateId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Widgets",
                column: "DashboardTemplateId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Widgets",
                schema: "ShoukouhPardis12DBAdmin");

            migrationBuilder.DropTable(
                name: "DashboardTemplates",
                schema: "ShoukouhPardis12DBAdmin");

            migrationBuilder.DropTable(
                name: "Dashboards",
                schema: "ShoukouhPardis12DBAdmin");
        }
    }
}
