using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Trabalho.Migrations
{
    public partial class firstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DbSetBank",
                columns: table => new
                {
                    Id_bank = table.Column<int>(type: "integer", nullable: false),
                    Conta = table.Column<string>(type: "text", nullable: true),
                    Nome = table.Column<string>(type: "text", nullable: true),
                    Limite = table.Column<double>(type: "double precision", nullable: false),
                    Saldo = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DbSetBank");
        }
    }
}
