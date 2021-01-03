using Microsoft.EntityFrameworkCore.Migrations;

namespace SportProject.Data.Migrations
{
    public partial class kursbirdaha : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Sports_SportsSportId",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Courses_SportsSportId",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "SportID",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "SportsSportId",
                table: "Courses");

            migrationBuilder.AddColumn<int>(
                name: "SportsId",
                table: "Courses",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Courses_SportsId",
                table: "Courses",
                column: "SportsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Sports_SportsId",
                table: "Courses",
                column: "SportsId",
                principalTable: "Sports",
                principalColumn: "SportId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Sports_SportsId",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Courses_SportsId",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "SportsId",
                table: "Courses");

            migrationBuilder.AddColumn<int>(
                name: "SportID",
                table: "Courses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SportsSportId",
                table: "Courses",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Courses_SportsSportId",
                table: "Courses",
                column: "SportsSportId");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Sports_SportsSportId",
                table: "Courses",
                column: "SportsSportId",
                principalTable: "Sports",
                principalColumn: "SportId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
