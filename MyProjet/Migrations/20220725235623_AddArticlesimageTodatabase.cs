using Microsoft.EntityFrameworkCore.Migrations;

namespace MyProjet.Migrations
{
    public partial class AddArticlesimageTodatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Articlesimages",
                columns: table => new
                {
                    Idimg = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    image = table.Column<string>(nullable: true),
                    articlebreak = table.Column<string>(nullable: true),
                    articlesNumAr = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articlesimages", x => x.Idimg);
                    table.ForeignKey(
                        name: "FK_Articlesimages_Articles_articlesNumAr",
                        column: x => x.articlesNumAr,
                        principalTable: "Articles",
                        principalColumn: "NumAr",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Articlesimages_articlesNumAr",
                table: "Articlesimages",
                column: "articlesNumAr");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Articlesimages");
        }
    }
}
