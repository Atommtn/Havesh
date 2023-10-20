using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HaveshApp.Migrations
{
    /// <inheritdoc />
    public partial class part2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
	        migrationBuilder.CreateTable(
		        name: "Branch",
		        schema: "ShoukouhPardis12DBAdmin",
		        columns: table => new
		        {
			        Id = table.Column<int>(type: "int", nullable: false)
				        .Annotation("SqlServer:Identity", "1, 1"),
			        Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
			        IsArchived = table.Column<bool>(type: "bit", nullable: false),
			        ParentBranch = table.Column<int>(type: "int", nullable: true)
		        },
		        constraints: table =>
		        {
			        table.PrimaryKey("PK_Branch", x => x.Id);
		        });

		}

		/// <inheritdoc />
		protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
