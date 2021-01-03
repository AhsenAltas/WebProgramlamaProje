using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SportProject.Data.Migrations
{
    public partial class kurslaryeniden : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comment_AspNetUsers_MemberId",
                table: "Comment");

            migrationBuilder.DropTable(
                name: "CourseCom");

            migrationBuilder.DropTable(
                name: "MemComty");

            migrationBuilder.DropTable(
                name: "MemMeet");

            migrationBuilder.DropTable(
                name: "MemSports");

            migrationBuilder.DropTable(
                name: "Post");

            migrationBuilder.DropTable(
                name: "Community");

            migrationBuilder.DropTable(
                name: "Meeting");

            migrationBuilder.DropTable(
                name: "City");

            migrationBuilder.DropTable(
                name: "Country");

            migrationBuilder.DropIndex(
                name: "IX_Comment_MemberId",
                table: "Comment");

            migrationBuilder.DropColumn(
                name: "MemberId",
                table: "Comment");

            migrationBuilder.AddColumn<int>(
                name: "SportId",
                table: "Courses",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SportId",
                table: "Courses");

            migrationBuilder.AddColumn<string>(
                name: "MemberId",
                table: "Comment",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Country",
                columns: table => new
                {
                    CountryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.CountryId);
                });

            migrationBuilder.CreateTable(
                name: "CourseCom",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CommentId = table.Column<int>(type: "int", nullable: true),
                    CoursesCourseId = table.Column<int>(type: "int", nullable: true)
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

            migrationBuilder.CreateTable(
                name: "MemSports",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MemberId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    SportsSportId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemSports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MemSports_AspNetUsers_MemberId",
                        column: x => x.MemberId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MemSports_Sports_SportsSportId",
                        column: x => x.SportsSportId,
                        principalTable: "Sports",
                        principalColumn: "SportId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Post",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CommentId = table.Column<int>(type: "int", nullable: true),
                    FotoUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MemberId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    PostDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SportId = table.Column<int>(type: "int", nullable: true),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Post", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Post_Comment_CommentId",
                        column: x => x.CommentId,
                        principalTable: "Comment",
                        principalColumn: "CommentId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Post_AspNetUsers_MemberId",
                        column: x => x.MemberId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Post_Sports_SportId",
                        column: x => x.SportId,
                        principalTable: "Sports",
                        principalColumn: "SportId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    CityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.CityId);
                    table.ForeignKey(
                        name: "FK_City_Country_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Country",
                        principalColumn: "CountryId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Community",
                columns: table => new
                {
                    ComId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityId = table.Column<int>(type: "int", nullable: true),
                    ComName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SportsSportId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Community", x => x.ComId);
                    table.ForeignKey(
                        name: "FK_Community_City_CityId",
                        column: x => x.CityId,
                        principalTable: "City",
                        principalColumn: "CityId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Community_Sports_SportsSportId",
                        column: x => x.SportsSportId,
                        principalTable: "Sports",
                        principalColumn: "SportId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Meeting",
                columns: table => new
                {
                    MeetId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ActTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Capasity = table.Column<int>(type: "int", nullable: true),
                    CityId = table.Column<int>(type: "int", nullable: true),
                    CountryId = table.Column<int>(type: "int", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SportsSportId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meeting", x => x.MeetId);
                    table.ForeignKey(
                        name: "FK_Meeting_City_CityId",
                        column: x => x.CityId,
                        principalTable: "City",
                        principalColumn: "CityId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Meeting_Country_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Country",
                        principalColumn: "CountryId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Meeting_Sports_SportsSportId",
                        column: x => x.SportsSportId,
                        principalTable: "Sports",
                        principalColumn: "SportId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MemComty",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CommunityComId = table.Column<int>(type: "int", nullable: true),
                    MemberId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemComty", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MemComty_Community_CommunityComId",
                        column: x => x.CommunityComId,
                        principalTable: "Community",
                        principalColumn: "ComId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MemComty_AspNetUsers_MemberId",
                        column: x => x.MemberId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MemMeet",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MeetingMeetId = table.Column<int>(type: "int", nullable: true),
                    MemberId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemMeet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MemMeet_Meeting_MeetingMeetId",
                        column: x => x.MeetingMeetId,
                        principalTable: "Meeting",
                        principalColumn: "MeetId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MemMeet_AspNetUsers_MemberId",
                        column: x => x.MemberId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comment_MemberId",
                table: "Comment",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_City_CountryId",
                table: "City",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Community_CityId",
                table: "Community",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Community_SportsSportId",
                table: "Community",
                column: "SportsSportId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseCom_CommentId",
                table: "CourseCom",
                column: "CommentId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseCom_CoursesCourseId",
                table: "CourseCom",
                column: "CoursesCourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Meeting_CityId",
                table: "Meeting",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Meeting_CountryId",
                table: "Meeting",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Meeting_SportsSportId",
                table: "Meeting",
                column: "SportsSportId");

            migrationBuilder.CreateIndex(
                name: "IX_MemComty_CommunityComId",
                table: "MemComty",
                column: "CommunityComId");

            migrationBuilder.CreateIndex(
                name: "IX_MemComty_MemberId",
                table: "MemComty",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_MemMeet_MeetingMeetId",
                table: "MemMeet",
                column: "MeetingMeetId");

            migrationBuilder.CreateIndex(
                name: "IX_MemMeet_MemberId",
                table: "MemMeet",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_MemSports_MemberId",
                table: "MemSports",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_MemSports_SportsSportId",
                table: "MemSports",
                column: "SportsSportId");

            migrationBuilder.CreateIndex(
                name: "IX_Post_CommentId",
                table: "Post",
                column: "CommentId");

            migrationBuilder.CreateIndex(
                name: "IX_Post_MemberId",
                table: "Post",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_Post_SportId",
                table: "Post",
                column: "SportId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_AspNetUsers_MemberId",
                table: "Comment",
                column: "MemberId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
