using Microsoft.EntityFrameworkCore.Migrations;

namespace MyProjet.Migrations
{
    public partial class addAccountToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    LoginName = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: true),
                    Categorie = table.Column<string>(nullable: true),
                    actif = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.LoginName);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Accounts");
        }
    }
}
