using Microsoft.EntityFrameworkCore.Migrations;

namespace SportProject.Data.Migrations
{
    public partial class karısmısmı : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "SportId",
                table: "Courses",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SportsSportId",
                table: "Courses",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Sports_SportsSportId",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Courses_SportsSportId",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "SportId",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "SportsSportId",
                table: "Courses");

            migrationBuilder.AddColumn<int>(
                name: "SportsId",
                table: "Courses",
                type: "int",
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
    }
}
