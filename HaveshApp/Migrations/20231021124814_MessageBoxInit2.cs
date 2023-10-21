using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HaveshApp.Migrations
{
    /// <inheritdoc />
    public partial class MessageBoxInit2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Message_MessageBoxes_MessageBoxId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Message");

            migrationBuilder.DropForeignKey(
                name: "FK_Message_Users_FromId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Message");

            migrationBuilder.DropForeignKey(
                name: "FK_Message_Users_ToId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Message");

            migrationBuilder.DropForeignKey(
                name: "FK_MessageAction_Message_MessageId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "MessageAction");

            migrationBuilder.DropForeignKey(
                name: "FK_MessageActionOption_MessageAction_MessageActionId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "MessageActionOption");

            migrationBuilder.DropForeignKey(
                name: "FK_ShokouhPardis_MediaAttachment_Message_MessageId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_MediaAttachment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MessageActionOption",
                schema: "ShoukouhPardis12DBAdmin",
                table: "MessageActionOption");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MessageAction",
                schema: "ShoukouhPardis12DBAdmin",
                table: "MessageAction");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Message",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Message");

            migrationBuilder.RenameTable(
                name: "MessageActionOption",
                schema: "ShoukouhPardis12DBAdmin",
                newName: "MessageActionOptions",
                newSchema: "ShoukouhPardis12DBAdmin");

            migrationBuilder.RenameTable(
                name: "MessageAction",
                schema: "ShoukouhPardis12DBAdmin",
                newName: "MessageActions",
                newSchema: "ShoukouhPardis12DBAdmin");

            migrationBuilder.RenameTable(
                name: "Message",
                schema: "ShoukouhPardis12DBAdmin",
                newName: "Messages",
                newSchema: "ShoukouhPardis12DBAdmin");

            migrationBuilder.RenameIndex(
                name: "IX_MessageActionOption_MessageActionId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "MessageActionOptions",
                newName: "IX_MessageActionOptions_MessageActionId");

            migrationBuilder.RenameIndex(
                name: "IX_MessageAction_MessageId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "MessageActions",
                newName: "IX_MessageActions_MessageId");

            migrationBuilder.RenameIndex(
                name: "IX_Message_ToId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Messages",
                newName: "IX_Messages_ToId");

            migrationBuilder.RenameIndex(
                name: "IX_Message_MessageBoxId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Messages",
                newName: "IX_Messages_MessageBoxId");

            migrationBuilder.RenameIndex(
                name: "IX_Message_FromId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Messages",
                newName: "IX_Messages_FromId");

            migrationBuilder.AlterColumn<bool>(
                name: "Gender",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Users",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDateTime",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Messages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeliveredDateTime",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Messages",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ReadDateTime",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Messages",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "SentDateTime",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Messages",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Severity",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Messages",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_MessageActionOptions",
                schema: "ShoukouhPardis12DBAdmin",
                table: "MessageActionOptions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MessageActions",
                schema: "ShoukouhPardis12DBAdmin",
                table: "MessageActions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Messages",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Messages",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MessageActionOptions_MessageActions_MessageActionId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "MessageActionOptions",
                column: "MessageActionId",
                principalSchema: "ShoukouhPardis12DBAdmin",
                principalTable: "MessageActions",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MessageActions_Messages_MessageId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "MessageActions",
                column: "MessageId",
                principalSchema: "ShoukouhPardis12DBAdmin",
                principalTable: "Messages",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_MessageBoxes_MessageBoxId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Messages",
                column: "MessageBoxId",
                principalSchema: "ShoukouhPardis12DBAdmin",
                principalTable: "MessageBoxes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Users_FromId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Messages",
                column: "FromId",
                principalSchema: "ShoukouhPardis12DBAdmin",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Users_ToId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Messages",
                column: "ToId",
                principalSchema: "ShoukouhPardis12DBAdmin",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_ShokouhPardis_MediaAttachment_Messages_MessageId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_MediaAttachment",
                column: "MessageId",
                principalSchema: "ShoukouhPardis12DBAdmin",
                principalTable: "Messages",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MessageActionOptions_MessageActions_MessageActionId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "MessageActionOptions");

            migrationBuilder.DropForeignKey(
                name: "FK_MessageActions_Messages_MessageId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "MessageActions");

            migrationBuilder.DropForeignKey(
                name: "FK_Messages_MessageBoxes_MessageBoxId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Messages");

            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Users_FromId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Messages");

            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Users_ToId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Messages");

            migrationBuilder.DropForeignKey(
                name: "FK_ShokouhPardis_MediaAttachment_Messages_MessageId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_MediaAttachment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Messages",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Messages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MessageActions",
                schema: "ShoukouhPardis12DBAdmin",
                table: "MessageActions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MessageActionOptions",
                schema: "ShoukouhPardis12DBAdmin",
                table: "MessageActionOptions");

            migrationBuilder.DropColumn(
                name: "CreateDateTime",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "DeliveredDateTime",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "ReadDateTime",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "SentDateTime",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "Severity",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Messages");

            migrationBuilder.RenameTable(
                name: "Messages",
                schema: "ShoukouhPardis12DBAdmin",
                newName: "Message",
                newSchema: "ShoukouhPardis12DBAdmin");

            migrationBuilder.RenameTable(
                name: "MessageActions",
                schema: "ShoukouhPardis12DBAdmin",
                newName: "MessageAction",
                newSchema: "ShoukouhPardis12DBAdmin");

            migrationBuilder.RenameTable(
                name: "MessageActionOptions",
                schema: "ShoukouhPardis12DBAdmin",
                newName: "MessageActionOption",
                newSchema: "ShoukouhPardis12DBAdmin");

            migrationBuilder.RenameIndex(
                name: "IX_Messages_ToId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Message",
                newName: "IX_Message_ToId");

            migrationBuilder.RenameIndex(
                name: "IX_Messages_MessageBoxId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Message",
                newName: "IX_Message_MessageBoxId");

            migrationBuilder.RenameIndex(
                name: "IX_Messages_FromId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Message",
                newName: "IX_Message_FromId");

            migrationBuilder.RenameIndex(
                name: "IX_MessageActions_MessageId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "MessageAction",
                newName: "IX_MessageAction_MessageId");

            migrationBuilder.RenameIndex(
                name: "IX_MessageActionOptions_MessageActionId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "MessageActionOption",
                newName: "IX_MessageActionOption_MessageActionId");

            migrationBuilder.AlterColumn<bool>(
                name: "Gender",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Message",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Message",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MessageAction",
                schema: "ShoukouhPardis12DBAdmin",
                table: "MessageAction",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MessageActionOption",
                schema: "ShoukouhPardis12DBAdmin",
                table: "MessageActionOption",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Message_MessageBoxes_MessageBoxId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Message",
                column: "MessageBoxId",
                principalSchema: "ShoukouhPardis12DBAdmin",
                principalTable: "MessageBoxes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Message_Users_FromId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Message",
                column: "FromId",
                principalSchema: "ShoukouhPardis12DBAdmin",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Message_Users_ToId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Message",
                column: "ToId",
                principalSchema: "ShoukouhPardis12DBAdmin",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MessageAction_Message_MessageId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "MessageAction",
                column: "MessageId",
                principalSchema: "ShoukouhPardis12DBAdmin",
                principalTable: "Message",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MessageActionOption_MessageAction_MessageActionId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "MessageActionOption",
                column: "MessageActionId",
                principalSchema: "ShoukouhPardis12DBAdmin",
                principalTable: "MessageAction",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ShokouhPardis_MediaAttachment_Message_MessageId",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_MediaAttachment",
                column: "MessageId",
                principalSchema: "ShoukouhPardis12DBAdmin",
                principalTable: "Message",
                principalColumn: "Id");
        }
    }
}
