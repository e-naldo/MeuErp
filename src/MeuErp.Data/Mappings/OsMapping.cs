using MeuErp.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MeuErp.Data.Mappings
{
    public class OsMapping : IEntityTypeConfiguration<Os>
    {
        public void Configure(EntityTypeBuilder<Os> builder)
        {
            builder.ToTable("os");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id).HasColumnName("id");
            builder.Property(p => p.ClienteId).HasColumnName("cliente_id").HasColumnType("int").IsRequired();
            builder.Property(p => p.EquipamentoId).HasColumnName("equipamento_id").HasColumnType("int").IsRequired();
            builder.Property(p => p.TipoOsId).HasColumnName("tipo_os_id").HasColumnType("int").IsRequired();
            builder.Property(p => p.SituacaoOsId).HasColumnName("situacao_os_id").HasColumnType("int").IsRequired();
            builder.Property(p => p.ValorTotal).HasColumnName("valor_total").HasColumnType("decimal(18,6)").IsRequired();
            builder.Property(p => p.FormaPagamento).HasColumnName("forma_pagamento").HasColumnType("varchar(50)").IsRequired();
            builder.Property(p => p.Observacao).HasColumnName("observacao").HasColumnType("varchar(max)");

            builder.HasOne(p => p.Cliente)
                .WithMany(p => p.Oss)
                .HasForeignKey(p => p.ClienteId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(p => p.Equipamento)
                .WithMany(p => p.Oss)
                .HasForeignKey(p => p.EquipamentoId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(p => p.TipoOs)
                .WithMany(p => p.Oss)
                .HasForeignKey(p => p.TipoOsId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(p => p.SituacaoOs)
                .WithMany(p => p.Oss)
                .HasForeignKey(p => p.SituacaoOsId)
                .OnDelete(DeleteBehavior.NoAction);

        }
    }
}
