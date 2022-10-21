using MeuErp.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MeuErp.Data.Mappings
{
    public class ItemProdutoOsMapping : IEntityTypeConfiguration<ItemProdutoOs>
    {
        public void Configure(EntityTypeBuilder<ItemProdutoOs> builder)
        {
            builder.ToTable("item_produto_os");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id).HasColumnName("id");
            builder.Property(p => p.OsId).HasColumnName("os_id").HasColumnType("int").IsRequired();
            builder.Property(p => p.ProdutoId).HasColumnName("produto_id").HasColumnType("int").IsRequired();
            builder.Property(p => p.Quantidade).HasColumnName("quantidade").HasColumnType("decimal(18,6)").IsRequired();
            builder.Property(p => p.ValorUnitario).HasColumnName("valor_unitario").HasColumnType("decimal(18,6)").IsRequired();
            builder.Property(p => p.ValorSubtotal).HasColumnName("valor_subtotal").HasColumnType("decimal(18,6)").IsRequired();
            builder.Property(p => p.TaxaDesconto).HasColumnName("taxa_desconto").HasColumnType("decimal(18,6)").IsRequired();
            builder.Property(p => p.ValorDesconto).HasColumnName("valor_desconto").HasColumnType("decimal(18,6)").IsRequired();
            builder.Property(p => p.ValorTotal).HasColumnName("valor_total").HasColumnType("decimal(18,6)").IsRequired();


            builder.HasOne(p => p.Os)
                .WithMany(p => p.ItensProdutos)
                .HasForeignKey(p => p.OsId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(p => p.Produto)
                .WithMany(p => p.ItensProdutos)
                 .HasForeignKey(p => p.ProdutoId)
                 .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
