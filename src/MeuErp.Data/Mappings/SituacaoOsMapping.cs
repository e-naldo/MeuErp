using MeuErp.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MeuErp.Data.Mappings
{
    public class SituacaoOsMapping : IEntityTypeConfiguration<SituacaoOs>
    { 
        public void Configure(EntityTypeBuilder<SituacaoOs> builder)
        {
            builder.ToTable("situacao_os");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id).HasColumnName("id");
            builder.Property(p => p.Nome).HasColumnName("nome").HasColumnType("varchar(100)").IsRequired();

        }
    }
}
