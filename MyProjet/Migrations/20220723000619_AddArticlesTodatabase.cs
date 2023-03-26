﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyProjet.Migrations
{
    public partial class AddArticlesTodatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Articles",
                columns: table => new
                {
                    NumAr = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameAr = table.Column<string>(nullable: false),
                    creationdate = table.Column<DateTime>(nullable: false),
                    Article = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(nullable: true),
                    theme = table.Column<string>(nullable: true),
                    images = table.Column<string>(nullable: false),
                    nbLike = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.NumAr);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Articles");
        }
    }
}
