using MeuErp.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MeuErp.Data.Mappings
{
    public class UnidadeClienteMapping : IEntityTypeConfiguration<UnidadeCliente>
    {
        public void Configure(EntityTypeBuilder<UnidadeCliente> builder)
        {
            builder.ToTable("unidade_cliente"); 
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).HasColumnName("id");
            builder.Property(p => p.ClienteId).HasColumnName("cliente_id").HasColumnType("int").IsRequired();
            builder.Property(p => p.Nome).HasColumnName("nome").HasColumnType("varchar(60)").IsRequired();
            builder.Property(p => p.Responsavel).HasColumnName("responsavel").HasColumnType("varchar(100)");
            builder.Property(p => p.Telefone).HasColumnName("telefone").HasColumnType("varchar(14)");
            builder.Property(p => p.Celular).HasColumnName("celular").HasColumnType("varchar(14)");
            builder.Property(p => p.CelularWhatsapp).HasColumnName("celular_whatsapp").HasColumnType("bit").HasDefaultValue(0);
            builder.Property(p => p.Email).HasColumnName("email").HasColumnType("varchar(150)");
            builder.Property(p => p.Logradouro).HasColumnName("logradouro").HasColumnType("varchar(60)").IsRequired();
            builder.Property(p => p.Numero).HasColumnName("numero").HasColumnType("varchar(10)").IsRequired();
            builder.Property(p => p.Complemento).HasColumnName("complemento").HasColumnType("varchar(60)");
            builder.Property(p => p.Bairro).HasColumnName("bairro").HasColumnType("varchar(60)").IsRequired();
            builder.Property(p => p.Municipio).HasColumnName("municipio").HasColumnType("varchar(60)").IsRequired();
            builder.Property(p => p.Uf).HasColumnName("uf").HasColumnType("char(2)").IsRequired();
            builder.Property(p => p.Cep).HasColumnName("cep").HasColumnType("char(8)").IsRequired();   

            builder.HasOne(p => p.Cliente).WithMany(p => p.Unidades).HasForeignKey(p => p.ClienteId);

        }
    }
}
