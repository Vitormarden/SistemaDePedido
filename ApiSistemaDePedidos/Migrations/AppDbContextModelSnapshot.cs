﻿// <auto-generated />
using System;
using ApiSistemaDePedidos.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ApiSistemaDePedidos.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ApiSistemaDePedidos.Models.Fornecedor", b =>
                {
                    b.Property<string>("Cnpj")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("EmailFornecedor")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Nf")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("NomeFornecedor")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("RazaoSocial")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Cnpj");

                    b.ToTable("Fornecedor");
                });

            modelBuilder.Entity("ApiSistemaDePedidos.Models.Pedido", b =>
                {
                    b.Property<int>("CodigoDoPedido")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CodigoDoPedido"));

                    b.Property<DateTime>("DataDoPedido")
                        .HasColumnType("datetime2");

                    b.Property<string>("Fornecedor")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("ProdutoDoPedido")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("QuantidadeDeProdutoNoPedido")
                        .HasColumnType("int");

                    b.Property<int>("ValorTotalDoPedido")
                        .HasColumnType("int");

                    b.HasKey("CodigoDoPedido");

                    b.ToTable("Pedido");
                });

            modelBuilder.Entity("ApiSistemaDePedidos.Models.Produto", b =>
                {
                    b.Property<string>("CodigoDoProduto")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime>("DataDeCadastroDoProduto")
                        .HasColumnType("datetime2");

                    b.Property<string>("DescriçãoDoProduto")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int>("ValorDoProduto")
                        .HasColumnType("int");

                    b.HasKey("CodigoDoProduto");

                    b.ToTable("Produto");
                });
#pragma warning restore 612, 618
        }
    }
}