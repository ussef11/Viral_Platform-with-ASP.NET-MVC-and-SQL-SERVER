using Microsoft.EntityFrameworkCore.Migrations;

namespace MyProjet.Migrations
{
    public partial class AddQuizzesTodatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Quizzes",
                columns: table => new
                {
                    NumChoose = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    theme = table.Column<string>(nullable: true),
                    title = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quizzes", x => x.NumChoose);
                });

            migrationBuilder.CreateTable(
                name: "chooseQuizzes",
                columns: table => new
                {
                    NumchooseQuizzes = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    choosetitle = table.Column<string>(nullable: true),
                    Answer = table.Column<string>(nullable: true),
                    CorrectAnswer = table.Column<string>(nullable: true),
                    image = table.Column<string>(nullable: true),
                    NumChoose = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_chooseQuizzes", x => x.NumchooseQuizzes);
                    table.ForeignKey(
                        name: "FK_chooseQuizzes_Quizzes_NumChoose",
                        column: x => x.NumChoose,
                        principalTable: "Quizzes",
                        principalColumn: "NumChoose",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_chooseQuizzes_NumChoose",
                table: "chooseQuizzes",
                column: "NumChoose");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "chooseQuizzes");

            migrationBuilder.DropTable(
                name: "Quizzes");
        }
    }
}
