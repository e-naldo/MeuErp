using MeuErp.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuErp.Data.Mappings
{
    public class ModeloEquipamentoMapping : IEntityTypeConfiguration<ModeloEquipamento>
    {
        public void Configure(EntityTypeBuilder<ModeloEquipamento> builder)
        {
            builder.ToTable("modelo_equipamento");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id).HasColumnName("id");
            builder.Property(p => p.Nome).HasColumnName("nome").HasColumnType("varchar(60)").IsRequired();

            builder.HasOne(p => p.MarcaEquipamento)
                .WithMany(p => p.ModelosEquipamentos)
                .HasForeignKey(p => p.MarcaEquipamentoId)
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
