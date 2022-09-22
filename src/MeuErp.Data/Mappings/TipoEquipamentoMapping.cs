using MeuErp.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MeuErp.Data.Mappings
{
    public class TipoEquipamentoMapping : IEntityTypeConfiguration<TipoEquipamento>
    {
        public void Configure(EntityTypeBuilder<TipoEquipamento> builder)
        {
            builder.ToTable("tipo_equipamento");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id).HasColumnName("id");
            builder.Property(p => p.Nome).HasColumnName("nome").HasColumnType("varchar(100)").IsRequired();

        }
    }
}
