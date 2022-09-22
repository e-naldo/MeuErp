using MeuErp.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MeuErp.Data.Mappings
{
    public class TipoOsMapping : IEntityTypeConfiguration<TipoOs>
    {
        public void Configure(EntityTypeBuilder<TipoOs> builder)
        {
            builder.ToTable("tipo_os");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id).HasColumnName("id");
            builder.Property(p => p.Nome).HasColumnName("nome").HasColumnType("varchar(100)").IsRequired();
            builder.Property(p => p.Descricao).HasColumnName("descricao").HasColumnType("varchar(max)");

        }
    }
}
