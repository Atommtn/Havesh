using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Havesh.Model.Migrations
{
    /// <inheritdoc />
    public partial class EditIds3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Online_TeacherLink",
                schema: "ShoukouhPardis12DBAdmin");

            migrationBuilder.DropTable(
                name: "Online_TermTable",
                schema: "ShoukouhPardis12DBAdmin");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Online_TeacherLink",
                schema: "ShoukouhPardis12DBAdmin",
                columns: table => new
                {
                    ItemID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Book = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValueSql: "(N'')"),
                    DocName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false, defaultValueSql: "(N'')"),
                    ItemCreatedBy = table.Column<int>(type: "int", nullable: true),
                    ItemCreatedWhen = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ItemGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ItemModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ItemModifiedWhen = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ItemOrder = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false, defaultValueSql: "(N'')"),
                    sessionNo = table.Column<int>(type: "int", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: false, defaultValueSql: "(N'')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Online_TeacherLink", x => x.ItemID);
                });

            migrationBuilder.CreateTable(
                name: "Online_TermTable",
                schema: "ShoukouhPardis12DBAdmin",
                columns: table => new
                {
                    ItemID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DayOf = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "(N'')"),
                    ItemCreatedBy = table.Column<int>(type: "int", nullable: true),
                    ItemCreatedWhen = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ItemGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ItemModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ItemModifiedWhen = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ItemOrder = table.Column<int>(type: "int", nullable: true),
                    Level = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "(N'')"),
                    NewProgram = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: true),
                    TeacherName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "(N'')"),
                    TimOf = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "(N'')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Online_TermTable", x => x.ItemID);
                });
        }
    }
}
