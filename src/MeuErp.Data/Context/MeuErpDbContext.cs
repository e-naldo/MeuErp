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
        public DbSet<MarcaEquipamento> MarcaEquipamento => Set<MarcaEquipamento>();
        public DbSet<ModeloEquipamento> ModeloEquipamento => Set<ModeloEquipamento>();
        public DbSet<TipoEquipamento> TipoEquipamento => Set<TipoEquipamento>();
        public DbSet<Equipamento> Equipamentos => Set<Equipamento>();
        public DbSet<ItemProdutoOs> ItemProdutoOs => Set<ItemProdutoOs>();
        public DbSet<ItemServicoOs> ItemServicoOs => Set<ItemServicoOs>();
        public DbSet<SituacaoOs> SituacaoOs => Set<SituacaoOs>();
        public DbSet<TipoOs> TipoOs => Set<TipoOs>();
        public DbSet<Os> Os => Set<Os>();

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
