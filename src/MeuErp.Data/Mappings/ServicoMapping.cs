using MeuErp.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MeuErp.Data.Mappings
{
    public class ServicoMapping : IEntityTypeConfiguration<Servico>
    {
        public void Configure(EntityTypeBuilder<Servico> builder)
        {
            builder.ToTable("servico"); 
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).HasColumnName("id");
            builder.Property(p => p.Referencia).HasColumnName("referencia").HasColumnType("varchar(20)");
            builder.Property(p => p.Nome).HasColumnName("nome").HasColumnType("varchar(150)").IsRequired();
            builder.Property(p => p.Descricao).HasColumnName("descricao").HasColumnType("varchar(max)").IsRequired();
            builder.Property(p => p.Preco).HasColumnName("preco").HasColumnType("decimal(18,6)").IsRequired();
            
        }
    }
}
