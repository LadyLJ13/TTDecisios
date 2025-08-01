using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebService.DAL.Migrations
{
    /// <inheritdoc />
    public partial class InitSqlLite : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Utilisateur",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false, defaultValueSql: "lower(hex(randomblob(16)))"),
                    Prenom = table.Column<string>(type: "TEXT", maxLength: 80, nullable: false),
                    Nom = table.Column<string>(type: "TEXT", maxLength: 80, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Utilisateur", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Utilisateur");
        }
    }
}
