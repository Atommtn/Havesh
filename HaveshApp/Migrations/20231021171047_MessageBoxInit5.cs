using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HaveshApp.Migrations
{
    /// <inheritdoc />
    public partial class MessageBoxInit5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ReplyToMessageId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Messages",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Messages_ReplyToMessageId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Messages",
                column: "ReplyToMessageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Messages_ReplyToMessageId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Messages",
                column: "ReplyToMessageId",
                principalSchema: "ShoukouhPardis12DBAdmin",
                principalTable: "Messages",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Messages_ReplyToMessageId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Messages");

            migrationBuilder.DropIndex(
                name: "IX_Messages_ReplyToMessageId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "ReplyToMessageId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Messages");
        }
    }
}
