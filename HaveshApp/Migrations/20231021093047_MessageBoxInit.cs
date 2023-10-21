using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HaveshApp.Migrations
{
    /// <inheritdoc />
    public partial class MessageBoxInit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MessageId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_MediaAttachment",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "MessageBoxes",
                schema: "ShoukouhPardis12DBAdmin",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OwnerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MessageBoxes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MessageBoxes_Users_OwnerId",
                        column: x => x.OwnerId,
                        principalSchema: "ShoukouhPardis12DBAdmin",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Message",
                schema: "ShoukouhPardis12DBAdmin",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FromId = table.Column<int>(type: "int", nullable: false),
                    ToId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Header = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Body = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MessageBoxId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Message", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Message_MessageBoxes_MessageBoxId",
                        column: x => x.MessageBoxId,
                        principalSchema: "ShoukouhPardis12DBAdmin",
                        principalTable: "MessageBoxes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Message_Users_FromId",
                        column: x => x.FromId,
                        principalSchema: "ShoukouhPardis12DBAdmin",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Message_Users_ToId",
                        column: x => x.ToId,
                        principalSchema: "ShoukouhPardis12DBAdmin",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "MessageAction",
                schema: "ShoukouhPardis12DBAdmin",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActionType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MessageId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MessageAction", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MessageAction_Message_MessageId",
                        column: x => x.MessageId,
                        principalSchema: "ShoukouhPardis12DBAdmin",
                        principalTable: "Message",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MessageActionOption",
                schema: "ShoukouhPardis12DBAdmin",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ActionUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MessageActionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MessageActionOption", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MessageActionOption_MessageAction_MessageActionId",
                        column: x => x.MessageActionId,
                        principalSchema: "ShoukouhPardis12DBAdmin",
                        principalTable: "MessageAction",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ShokouhPardis_MediaAttachment_MessageId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_MediaAttachment",
                column: "MessageId");

            migrationBuilder.CreateIndex(
                name: "IX_Message_FromId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Message",
                column: "FromId");

            migrationBuilder.CreateIndex(
                name: "IX_Message_MessageBoxId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Message",
                column: "MessageBoxId");

            migrationBuilder.CreateIndex(
                name: "IX_Message_ToId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Message",
                column: "ToId");

            migrationBuilder.CreateIndex(
                name: "IX_MessageAction_MessageId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "MessageAction",
                column: "MessageId");

            migrationBuilder.CreateIndex(
                name: "IX_MessageActionOption_MessageActionId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "MessageActionOption",
                column: "MessageActionId");

            migrationBuilder.CreateIndex(
                name: "IX_MessageBoxes_OwnerId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "MessageBoxes",
                column: "OwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_ShokouhPardis_MediaAttachment_Message_MessageId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_MediaAttachment",
                column: "MessageId",
                principalSchema: "ShoukouhPardis12DBAdmin",
                principalTable: "Message",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShokouhPardis_MediaAttachment_Message_MessageId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_MediaAttachment");

            migrationBuilder.DropTable(
                name: "MessageActionOption",
                schema: "ShoukouhPardis12DBAdmin");

            migrationBuilder.DropTable(
                name: "MessageAction",
                schema: "ShoukouhPardis12DBAdmin");

            migrationBuilder.DropTable(
                name: "Message",
                schema: "ShoukouhPardis12DBAdmin");

            migrationBuilder.DropTable(
                name: "MessageBoxes",
                schema: "ShoukouhPardis12DBAdmin");

            migrationBuilder.DropIndex(
                name: "IX_ShokouhPardis_MediaAttachment_MessageId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_MediaAttachment");

            migrationBuilder.DropColumn(
                name: "MessageId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_MediaAttachment");
        }
    }
}
