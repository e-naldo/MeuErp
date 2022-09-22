using MeuErp.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MeuErp.Data.Mappings
{
    public class ProdutoMapping : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.ToTable("produto"); 
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).HasColumnName("id");
            builder.Property(p => p.GrupoProdutoId).HasColumnName("grupo_produto_id").HasColumnType("int");
            builder.Property(p => p.Referencia).HasColumnName("referencia").HasColumnType("varchar(20)");
            builder.Property(p => p.Nome).HasColumnName("nome").HasColumnType("varchar(150)").IsRequired();
            builder.Property(p => p.Descricao).HasColumnName("descricao").HasColumnType("varchar(max)").IsRequired();
            builder.Property(p => p.Unidade).HasColumnName("unidade").HasColumnType("varchar(4)").IsRequired();
            builder.Property(p => p.PrecoCompra).HasColumnName("preco_compra").HasColumnType("decimal(18,6)").IsRequired();
            builder.Property(p => p.PrecoVenda).HasColumnName("preco_venda").HasColumnType("decimal(18,6)").IsRequired();
            builder.Property(p => p.PrecoMaximo).HasColumnName("preco_maximo").HasColumnType("decimal(18,6)").IsRequired();
            builder.Property(p => p.PrecoMinimo).HasColumnName("preco_minimo").HasColumnType("decimal(18,6)").IsRequired();

            builder.HasOne(p => p.GrupoProduto).WithMany(p => p.Produtos).HasForeignKey(p => p.GrupoProdutoId).OnDelete(DeleteBehavior.SetNull);

        }
    }
}
