using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SportProject.Data.Migrations
{
    public partial class mig5 : Migration
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
                name: "CourseCom",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CoursesCourseId = table.Column<int>(nullable: true),
                    CommentId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseCom", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CourseCom_Comment_CommentId",
                        column: x => x.CommentId,
                        principalTable: "Comment",
                        principalColumn: "CommentId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CourseCom_Courses_CoursesCourseId",
                        column: x => x.CoursesCourseId,
                        principalTable: "Courses",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CourseCom_CommentId",
                table: "CourseCom",
                column: "CommentId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseCom_CoursesCourseId",
                table: "CourseCom",
                column: "CoursesCourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_SportsSportId",
                table: "Courses",
                column: "SportsSportId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourseCom");

            migrationBuilder.DropTable(
                name: "Courses");
        }
    }
}
