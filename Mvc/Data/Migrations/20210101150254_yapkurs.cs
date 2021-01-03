using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SportProject.Data.Migrations
{
    public partial class yapkurs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    CourseId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseName = table.Column<string>(nullable: true),
                    SiteUrl = table.Column<string>(nullable: true),
                    InfoCourse = table.Column<string>(nullable: true),
                    ActTime = table.Column<DateTime>(nullable: false),
                    SportID = table.Column<int>(nullable: false),
                    SportsSportId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.CourseId);
                    table.ForeignKey(
                        name: "FK_Courses_Sports_SportsSportId",
                        column: x => x.SportsSportId,
                        principalTable: "Sports",
                        principalColumn: "SportId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Comment",
                columns: table => new
                {
                    CommentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CommentTxt = table.Column<string>(nullable: true),
                    SendDate = table.Column<DateTime>(nullable: false),
                    ComApproval = table.Column<bool>(nullable: false),
                    CourseId = table.Column<int>(nullable: false),
                    CoursesCourseId = table.Column<int>(nullable: true),
                    MemberId = table.Column<int>(nullable: false),
                    MemberId1 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comment", x => x.CommentId);
                    table.ForeignKey(
                        name: "FK_Comment_Courses_CoursesCourseId",
                        column: x => x.CoursesCourseId,
                        principalTable: "Courses",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Comment_AspNetUsers_MemberId1",
                        column: x => x.MemberId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comment_CoursesCourseId",
                table: "Comment",
                column: "CoursesCourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_MemberId1",
                table: "Comment",
                column: "MemberId1");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_SportsSportId",
                table: "Courses",
                column: "SportsSportId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comment");

            migrationBuilder.DropTable(
                name: "Courses");
        }
    }
}
