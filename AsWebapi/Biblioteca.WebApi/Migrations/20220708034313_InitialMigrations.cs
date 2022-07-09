using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Biblioteca.WebApi.Migrations
{
    public partial class InitialMigrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "autor",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    nome = table.Column<string>(type: "VARCHAR", maxLength: 80, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_autor", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "cliente",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    nome = table.Column<string>(type: "VARCHAR", maxLength: 80, nullable: false),
                    telefone = table.Column<string>(type: "VARCHAR", maxLength: 16, nullable: false),
                    email = table.Column<string>(type: "VARCHAR", maxLength: 30, nullable: false),
                    cpf = table.Column<string>(type: "VARCHAR", maxLength: 11, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cliente", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "editora",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    nome = table.Column<string>(type: "VARCHAR", maxLength: 80, nullable: false),
                    cidade = table.Column<string>(type: "VARCHAR", maxLength: 80, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_editora", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "genero",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    nome = table.Column<string>(type: "VARCHAR", maxLength: 80, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_genero", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "livro",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    titulo = table.Column<string>(type: "VARCHAR", maxLength: 80, nullable: false),
                    volume = table.Column<int>(type: "INTEGER", nullable: false),
                    editora_id = table.Column<int>(type: "INTEGER", nullable: false),
                    genero_id = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_livro", x => x.id);
                    table.ForeignKey(
                        name: "FK_Livro_Editora",
                        column: x => x.editora_id,
                        principalTable: "editora",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Livro_Genero",
                        column: x => x.genero_id,
                        principalTable: "genero",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "emprestimo",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    data_emprestimo = table.Column<DateTime>(type: "SMALLDATETIME", nullable: false),
                    data_devolucao = table.Column<DateTime>(type: "SMALLDATETIME", nullable: false),
                    livro_id = table.Column<int>(type: "INTEGER", nullable: false),
                    cliente_id = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_emprestimo", x => x.id);
                    table.ForeignKey(
                        name: "FK_Emprestimo_Cliente",
                        column: x => x.cliente_id,
                        principalTable: "cliente",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Emprestimo_Livro",
                        column: x => x.livro_id,
                        principalTable: "livro",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "livro_autor",
                columns: table => new
                {
                    autor_id = table.Column<int>(type: "INTEGER", nullable: false),
                    livro_id = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_livro_autor", x => new { x.autor_id, x.livro_id });
                    table.ForeignKey(
                        name: "FK_livro_autor_autor_id",
                        column: x => x.autor_id,
                        principalTable: "autor",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_livro_autor_livro_id",
                        column: x => x.livro_id,
                        principalTable: "livro",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_emprestimo_cliente_id",
                table: "emprestimo",
                column: "cliente_id");

            migrationBuilder.CreateIndex(
                name: "IX_emprestimo_livro_id",
                table: "emprestimo",
                column: "livro_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_livro_editora_id",
                table: "livro",
                column: "editora_id");

            migrationBuilder.CreateIndex(
                name: "IX_livro_genero_id",
                table: "livro",
                column: "genero_id");

            migrationBuilder.CreateIndex(
                name: "IX_livro_autor_livro_id",
                table: "livro_autor",
                column: "livro_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "emprestimo");

            migrationBuilder.DropTable(
                name: "livro_autor");

            migrationBuilder.DropTable(
                name: "cliente");

            migrationBuilder.DropTable(
                name: "autor");

            migrationBuilder.DropTable(
                name: "livro");

            migrationBuilder.DropTable(
                name: "editora");

            migrationBuilder.DropTable(
                name: "genero");
        }
    }
}
