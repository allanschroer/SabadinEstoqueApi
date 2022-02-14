﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using SabadinEstoqueApi.Infra;

namespace SabadinEstoqueApi.Infra.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20220214000130_second")]
    partial class second
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityByDefaultColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("SabadinEstoqueApi.Dominio.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("Nome")
                        .HasMaxLength(200)
                        .HasColumnType("varchar")
                        .HasColumnName("nome");

                    b.Property<short>("Situacao")
                        .HasColumnType("smallint")
                        .HasColumnName("situacao");

                    b.HasKey("Id");

                    b.ToTable("categorias");
                });

            modelBuilder.Entity("SabadinEstoqueApi.Dominio.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("Cpf")
                        .HasColumnType("text");

                    b.Property<string>("Nome")
                        .HasColumnType("text");

                    b.Property<string>("Telefone")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("SabadinEstoqueApi.Dominio.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id")
                        .UseIdentityByDefaultColumn();

                    b.Property<int>("IdCategoria")
                        .HasColumnType("int")
                        .HasColumnName("idcategoria");

                    b.Property<string>("Nome")
                        .HasMaxLength(200)
                        .HasColumnType("varchar")
                        .HasColumnName("nome");

                    b.Property<int>("QtdEstoque")
                        .HasColumnType("int")
                        .HasColumnName("qtdestoque");

                    b.Property<int>("QtdEstoqueMinimo")
                        .HasColumnType("int")
                        .HasColumnName("qtdestoqueminimo");

                    b.Property<short>("Situacao")
                        .HasColumnType("smallint")
                        .HasColumnName("situacao");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal")
                        .HasColumnName("valor");

                    b.Property<decimal>("ValorPromocao")
                        .HasColumnType("decimal")
                        .HasColumnName("valorpromocao");

                    b.HasKey("Id");

                    b.HasIndex("IdCategoria");

                    b.ToTable("produtos");
                });

            modelBuilder.Entity("SabadinEstoqueApi.Dominio.ProdutoVenda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<int>("IdProduto")
                        .HasColumnType("integer");

                    b.Property<int?>("ProdutoId")
                        .HasColumnType("integer");

                    b.Property<int>("QuantidadeVenda")
                        .HasColumnType("integer");

                    b.Property<double>("ValorBruto")
                        .HasColumnType("double precision");

                    b.Property<double>("ValorDesconto")
                        .HasColumnType("double precision");

                    b.Property<double>("ValorFinal")
                        .HasColumnType("double precision");

                    b.Property<int?>("VendaId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ProdutoId");

                    b.HasIndex("VendaId");

                    b.ToTable("ProdutoVenda");
                });

            modelBuilder.Entity("SabadinEstoqueApi.Dominio.Venda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<int?>("ClienteId")
                        .HasColumnType("integer");

                    b.Property<int>("Finalizador")
                        .HasColumnType("integer");

                    b.Property<int>("QuatidadeParcelas")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.ToTable("Vendas");
                });

            modelBuilder.Entity("SabadinEstoqueApi.Dominio.Produto", b =>
                {
                    b.HasOne("SabadinEstoqueApi.Dominio.Categoria", "Categoria")
                        .WithMany()
                        .HasForeignKey("IdCategoria")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");
                });

            modelBuilder.Entity("SabadinEstoqueApi.Dominio.ProdutoVenda", b =>
                {
                    b.HasOne("SabadinEstoqueApi.Dominio.Produto", "Produto")
                        .WithMany()
                        .HasForeignKey("ProdutoId");

                    b.HasOne("SabadinEstoqueApi.Dominio.Venda", null)
                        .WithMany("Produtos")
                        .HasForeignKey("VendaId");

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("SabadinEstoqueApi.Dominio.Venda", b =>
                {
                    b.HasOne("SabadinEstoqueApi.Dominio.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId");

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("SabadinEstoqueApi.Dominio.Venda", b =>
                {
                    b.Navigation("Produtos");
                });
#pragma warning restore 612, 618
        }
    }
}
