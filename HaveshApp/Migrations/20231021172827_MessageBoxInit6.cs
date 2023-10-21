using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HaveshApp.Migrations
{
    /// <inheritdoc />
    public partial class MessageBoxInit6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ReplyOriginalMessage",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Messages",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReplyOriginalMessage",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Messages");
        }
    }
}
