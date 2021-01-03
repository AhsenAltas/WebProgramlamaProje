using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SportProject.Data.Migrations
{
    public partial class forComment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "ComApproval",
                table: "Comment",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "CourseId",
                table: "Comment",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CoursesCourseId",
                table: "Comment",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MemberId",
                table: "Comment",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "MemberId1",
                table: "Comment",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "SendDate",
                table: "Comment",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateIndex(
                name: "IX_Comment_CoursesCourseId",
                table: "Comment",
                column: "CoursesCourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_MemberId1",
                table: "Comment",
                column: "MemberId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_Courses_CoursesCourseId",
                table: "Comment",
                column: "CoursesCourseId",
                principalTable: "Courses",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_AspNetUsers_MemberId1",
                table: "Comment",
                column: "MemberId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comment_Courses_CoursesCourseId",
                table: "Comment");

            migrationBuilder.DropForeignKey(
                name: "FK_Comment_AspNetUsers_MemberId1",
                table: "Comment");

            migrationBuilder.DropIndex(
                name: "IX_Comment_CoursesCourseId",
                table: "Comment");

            migrationBuilder.DropIndex(
                name: "IX_Comment_MemberId1",
                table: "Comment");

            migrationBuilder.DropColumn(
                name: "ComApproval",
                table: "Comment");

            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "Comment");

            migrationBuilder.DropColumn(
                name: "CoursesCourseId",
                table: "Comment");

            migrationBuilder.DropColumn(
                name: "MemberId",
                table: "Comment");

            migrationBuilder.DropColumn(
                name: "MemberId1",
                table: "Comment");

            migrationBuilder.DropColumn(
                name: "SendDate",
                table: "Comment");
        }
    }
}
