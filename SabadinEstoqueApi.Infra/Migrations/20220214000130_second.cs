using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace SabadinEstoqueApi.Infra.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "cliente",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    cpf = table.Column<string>(type: "text", nullable: true),
                    nome = table.Column<string>(type: "text", nullable: true),
                    telefone = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "vendas",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    finalizador = table.Column<int>(type: "integer", nullable: false),
                    quatidadeparcelas = table.Column<int>(type: "integer", nullable: false),
                    idcliente = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendas", x => x.id);
                    table.ForeignKey(
                        name: "FK_Vendas_Cliente_IdCliente",
                        column: x => x.idcliente,
                        principalTable: "cliente",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "produtovenda",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    quantidadevenda = table.Column<int>(type: "integer", nullable: false),
                    valorfinal = table.Column<double>(type: "double precision", nullable: false),
                    valorbruto = table.Column<double>(type: "double precision", nullable: false),
                    valordesconto = table.Column<double>(type: "double precision", nullable: false),
                    idproduto = table.Column<int>(type: "integer", nullable: false),
                    idvenda = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProdutoVenda", x => x.id);
                    table.ForeignKey(
                        name: "FK_ProdutoVenda_produtos_ProdutoId",
                        column: x => x.idproduto,
                        principalTable: "produtos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProdutoVenda_Vendas_VendaId",
                        column: x => x.idvenda,
                        principalTable: "vendas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProdutoVenda_ProdutoId",
                table: "produtovenda",
                column: "idproduto");

            migrationBuilder.CreateIndex(
                name: "IX_ProdutoVenda_VendaId",
                table: "produtovenda",
                column: "idvenda");

            migrationBuilder.CreateIndex(
                name: "IX_Vendas_ClienteId",
                table: "vendas",
                column: "idcliente");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProdutoVenda");

            migrationBuilder.DropTable(
                name: "Vendas");

            migrationBuilder.DropTable(
                name: "Cliente");
        }
    }
}
