using Microsoft.EntityFrameworkCore.Migrations;

namespace SportProject.Data.Migrations
{
    public partial class yorumdenemesi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comment_AspNetUsers_MemberId1",
                table: "Comment");

            migrationBuilder.DropIndex(
                name: "IX_Comment_MemberId1",
                table: "Comment");

            migrationBuilder.DropColumn(
                name: "ComApproval",
                table: "Comment");

            migrationBuilder.DropColumn(
                name: "MemberId",
                table: "Comment");

            migrationBuilder.DropColumn(
                name: "MemberId1",
                table: "Comment");

            migrationBuilder.AddColumn<string>(
                name: "UserNick",
                table: "Comment",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserNick",
                table: "Comment");

            migrationBuilder.AddColumn<bool>(
                name: "ComApproval",
                table: "Comment",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "MemberId",
                table: "Comment",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "MemberId1",
                table: "Comment",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Comment_MemberId1",
                table: "Comment",
                column: "MemberId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_AspNetUsers_MemberId1",
                table: "Comment",
                column: "MemberId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
