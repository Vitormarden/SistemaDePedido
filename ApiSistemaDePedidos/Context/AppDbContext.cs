using ApiSistemaDePedidos.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiSistemaDePedidos.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Fornecedor> fornecedores { get; set; }
        public DbSet<Pedido> pedidos { get; set; }
        public DbSet<Produto> produtos { get; set; }
    }
}
