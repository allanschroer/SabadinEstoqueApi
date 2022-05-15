using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace SabadinEstoqueApi.Infra.Migrations
{
    public partial class added_usuario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DataHoraCadastro",
                table: "produtos",
                type: "timestamp",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "dataatualizacao",
                table: "produtos",
                type: "timestamp",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "idusuarioalteracao",
                table: "produtos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idusuariocadastro",
                table: "produtos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataHoraCadastro",
                table: "categorias",
                type: "timestamp",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "dataatualizacao",
                table: "categorias",
                type: "timestamp",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "idusuarioalteracao",
                table: "categorias",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idusuariocadastro",
                table: "categorias",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "usuario",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nome = table.Column<string>(type: "varchar", maxLength: 50, nullable: false),
                    email = table.Column<string>(type: "varchar", maxLength: 50, nullable: false),
                    codigo = table.Column<string>(type: "varchar", maxLength: 20, nullable: false),
                    senha = table.Column<string>(type: "varchar", maxLength: 20, nullable: false),
                    nivelacesso = table.Column<int>(type: "smallint", nullable: false),
                    situacao = table.Column<int>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuario", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_produtos_idusuarioalteracao",
                table: "produtos",
                column: "idusuarioalteracao");

            migrationBuilder.CreateIndex(
                name: "IX_produtos_idusuariocadastro",
                table: "produtos",
                column: "idusuariocadastro");

            migrationBuilder.CreateIndex(
                name: "IX_categorias_idusuarioalteracao",
                table: "categorias",
                column: "idusuarioalteracao");

            migrationBuilder.CreateIndex(
                name: "IX_categorias_idusuariocadastro",
                table: "categorias",
                column: "idusuariocadastro");

            migrationBuilder.AddForeignKey(
                name: "FK_categorias_usuario_idusuarioalteracao",
                table: "categorias",
                column: "idusuarioalteracao",
                principalTable: "usuario",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_categorias_usuario_idusuariocadastro",
                table: "categorias",
                column: "idusuariocadastro",
                principalTable: "usuario",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_produtos_usuario_idusuarioalteracao",
                table: "produtos",
                column: "idusuarioalteracao",
                principalTable: "usuario",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_produtos_usuario_idusuariocadastro",
                table: "produtos",
                column: "idusuariocadastro",
                principalTable: "usuario",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_categorias_usuario_idusuarioalteracao",
                table: "categorias");

            migrationBuilder.DropForeignKey(
                name: "FK_categorias_usuario_idusuariocadastro",
                table: "categorias");

            migrationBuilder.DropForeignKey(
                name: "FK_produtos_usuario_idusuarioalteracao",
                table: "produtos");

            migrationBuilder.DropForeignKey(
                name: "FK_produtos_usuario_idusuariocadastro",
                table: "produtos");

            migrationBuilder.DropTable(
                name: "usuario");

            migrationBuilder.DropIndex(
                name: "IX_produtos_idusuarioalteracao",
                table: "produtos");

            migrationBuilder.DropIndex(
                name: "IX_produtos_idusuariocadastro",
                table: "produtos");

            migrationBuilder.DropIndex(
                name: "IX_categorias_idusuarioalteracao",
                table: "categorias");

            migrationBuilder.DropIndex(
                name: "IX_categorias_idusuariocadastro",
                table: "categorias");

            migrationBuilder.DropColumn(
                name: "DataHoraCadastro",
                table: "produtos");

            migrationBuilder.DropColumn(
                name: "dataatualizacao",
                table: "produtos");

            migrationBuilder.DropColumn(
                name: "idusuarioalteracao",
                table: "produtos");

            migrationBuilder.DropColumn(
                name: "idusuariocadastro",
                table: "produtos");

            migrationBuilder.DropColumn(
                name: "DataHoraCadastro",
                table: "categorias");

            migrationBuilder.DropColumn(
                name: "dataatualizacao",
                table: "categorias");

            migrationBuilder.DropColumn(
                name: "idusuarioalteracao",
                table: "categorias");

            migrationBuilder.DropColumn(
                name: "idusuariocadastro",
                table: "categorias");
        }
    }
}
