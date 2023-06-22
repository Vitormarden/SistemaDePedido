using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiSistemaDePedidos.Migrations
{
    /// <inheritdoc />
    public partial class inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Fornecedor",
                columns: table => new
                {
                    Cnpj = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RazaoSocial = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Nf = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    EmailFornecedor = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    NomeFornecedor = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fornecedor", x => x.Cnpj);
                });

            migrationBuilder.CreateTable(
                name: "Pedido",
                columns: table => new
                {
                    CodigoDoPedido = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataDoPedido = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProdutoDoPedido = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    QuantidadeDeProdutoNoPedido = table.Column<int>(type: "int", nullable: false),
                    Fornecedor = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ValorTotalDoPedido = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedido", x => x.CodigoDoPedido);
                });

            migrationBuilder.CreateTable(
                name: "Produto",
                columns: table => new
                {
                    CodigoDoProduto = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    DescriçãoDoProduto = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    DataDeCadastroDoProduto = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ValorDoProduto = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produto", x => x.CodigoDoProduto);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Fornecedor");

            migrationBuilder.DropTable(
                name: "Pedido");

            migrationBuilder.DropTable(
                name: "Produto");
        }
    }
}
