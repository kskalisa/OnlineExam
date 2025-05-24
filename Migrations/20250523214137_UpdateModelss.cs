using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExamFinal.Migrations
{
    /// <inheritdoc />
    public partial class UpdateModelss : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentAnswers_StudentExams_StudentExamId1",
                table: "StudentAnswers");

            migrationBuilder.DropIndex(
                name: "IX_StudentAnswers_StudentExamId1",
                table: "StudentAnswers");

            migrationBuilder.DropColumn(
                name: "StudentExamId1",
                table: "StudentAnswers");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StudentExamId1",
                table: "StudentAnswers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_StudentAnswers_StudentExamId1",
                table: "StudentAnswers",
                column: "StudentExamId1");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentAnswers_StudentExams_StudentExamId1",
                table: "StudentAnswers",
                column: "StudentExamId1",
                principalTable: "StudentExams",
                principalColumn: "Id");
        }
    }
}
