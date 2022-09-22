using MeuErp.Business.Models;
using Microsoft.EntityFrameworkCore;

namespace MeuErp.Data.Context
{
    public class MeuErpDbContext : DbContext
    {
        public DbSet<Cliente> Clientes => Set<Cliente>();
        public DbSet<GrupoProduto> GruposProdutos => Set<GrupoProduto>();
        public DbSet<Produto> Produtos => Set<Produto>();
        public DbSet<Servico> Servicos => Set<Servico>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server = localhost; Database = MeuErp; Trusted_Connection = True"
                );
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MeuErpDbContext).Assembly);

            base.OnModelCreating(modelBuilder);
        }
    }
}
