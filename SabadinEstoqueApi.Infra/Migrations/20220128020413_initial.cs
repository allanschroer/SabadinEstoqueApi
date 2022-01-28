using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace SabadinEstoqueApi.Infra.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "categorias",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nome = table.Column<string>(type: "varchar", maxLength: 200, nullable: true),
                    situacao = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categorias", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "produtos",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nome = table.Column<string>(type: "varchar", maxLength: 200, nullable: true),
                    qtdestoque = table.Column<int>(type: "int", nullable: false),
                    qtdestoqueminimo = table.Column<int>(type: "int", nullable: false),
                    valor = table.Column<decimal>(type: "decimal", nullable: false),
                    valorpromocao = table.Column<decimal>(type: "decimal", nullable: false),
                    situacao = table.Column<short>(type: "smallint", nullable: false),
                    idcategoria = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_produtos", x => x.id);
                    table.ForeignKey(
                        name: "FK_produtos_categorias_idcategoria",
                        column: x => x.idcategoria,
                        principalTable: "categorias",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_produtos_idcategoria",
                table: "produtos",
                column: "idcategoria");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "produtos");

            migrationBuilder.DropTable(
                name: "categorias");
        }
    }
}
