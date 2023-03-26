using Microsoft.EntityFrameworkCore.Migrations;

namespace MyProjet.Migrations
{
    public partial class Addcovercolumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "cover",
                table: "Quizzes",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "cover",
                table: "Quizzes");
        }
    }
}
