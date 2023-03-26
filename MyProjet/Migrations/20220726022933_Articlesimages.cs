using Microsoft.EntityFrameworkCore.Migrations;

namespace MyProjet.Migrations
{
    public partial class Articlesimages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articlesimages_Articles_articlesNumAr",
                table: "Articlesimages");

            migrationBuilder.AlterColumn<int>(
                name: "articlesNumAr",
                table: "Articlesimages",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Articlesimages_Articles_articlesNumAr",
                table: "Articlesimages",
                column: "articlesNumAr",
                principalTable: "Articles",
                principalColumn: "NumAr",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articlesimages_Articles_articlesNumAr",
                table: "Articlesimages");

            migrationBuilder.AlterColumn<int>(
                name: "articlesNumAr",
                table: "Articlesimages",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Articlesimages_Articles_articlesNumAr",
                table: "Articlesimages",
                column: "articlesNumAr",
                principalTable: "Articles",
                principalColumn: "NumAr",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
