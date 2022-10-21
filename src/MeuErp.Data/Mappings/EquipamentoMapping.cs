using MeuErp.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MeuErp.Data.Mappings
{
    public class EquipamentoMapping : IEntityTypeConfiguration<Equipamento>
    {
        public void Configure(EntityTypeBuilder<Equipamento> builder)
        {
            builder.ToTable("equipamento");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).HasColumnName("id");
            builder.Property(p => p.TipoEquipamentoId).HasColumnName("tipo_equipamento_id").HasColumnType("int").IsRequired();
            builder.Property(p => p.MarcaEquipamentoId).HasColumnName("marca_equipamento_id").HasColumnType("int").IsRequired();
            builder.Property(p => p.ModeloEquipamentoId).HasColumnName("modelo_equipamento_id").HasColumnType("int");
            builder.Property(p => p.ClienteId).HasColumnName("cliente_id").HasColumnType("int").IsRequired();
            builder.Property(p => p.UnidadeClienteId).HasColumnName("unidade_cliente_id").HasColumnType("int");
            builder.Property(p => p.NumeroSerie).HasColumnName("numero_serie").HasColumnType("varchar(50)").IsRequired();
            builder.Property(p => p.NumeroLote).HasColumnName("numero_lote").HasColumnType("varchar(20)");
            builder.Property(p => p.DataFabricacao).HasColumnName("data_fabricacao").HasColumnType("datetime2");
            builder.Property(p => p.DataFimGarantia).HasColumnName("data_fim_garantia").HasColumnType("datetime2");
            builder.Property(p => p.DataCadastro).HasColumnName("data_cadastro").HasColumnType("datetime2").IsRequired().HasDefaultValueSql("GETDATE()").ValueGeneratedOnAdd();
            builder.Property(p => p.Observacao).HasColumnName("observacao").HasColumnType("varchar");
            builder.Property(p => p.Inativo).HasColumnName("inativo").HasColumnType("bit").HasDefaultValue(false).IsRequired();


            builder.HasOne(p => p.TipoEquipamento)
                .WithMany(p => p.Equipamentos)
                .HasForeignKey(p => p.TipoEquipamentoId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(p => p.MarcaEquipamento)
                .WithMany(p => p.Equipamentos)
                .HasForeignKey(p => p.MarcaEquipamentoId)
                .OnDelete(DeleteBehavior.NoAction);
            
            builder.HasOne(p => p.ModeloEquipamento)
                .WithMany(p => p.Equipamentos)
                .HasForeignKey(p => p.ModeloEquipamentoId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(p => p.Cliente)
                .WithMany(p => p.Equipamentos)
                .HasForeignKey(p => p.ClienteId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(p => p.UnidadeCliente)
                .WithMany(p => p.Equipamentos)
                .HasForeignKey(p => p.UnidadeClienteId)
                .OnDelete(DeleteBehavior.NoAction);

        }
    }
}
