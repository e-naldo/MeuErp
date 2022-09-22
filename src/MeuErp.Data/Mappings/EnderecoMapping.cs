using MeuErp.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MeuErp.Data.Mappings
{
    public class EnderecoMapping : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.ToTable("endereco"); 
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).HasColumnName("id");
            builder.Property(p => p.ClienteId).HasColumnName("cliente_id").HasColumnType("int").IsRequired();
            builder.Property(p => p.Descricao).HasColumnName("descricao").HasColumnType("varchar(60)").IsRequired();
            builder.Property(p => p.Logradouro).HasColumnName("logradouro").HasColumnType("varchar(60)").IsRequired();
            builder.Property(p => p.Numero).HasColumnName("numero").HasColumnType("varchar(10)").IsRequired();
            builder.Property(p => p.Complemento).HasColumnName("complemento").HasColumnType("varchar(60)");
            builder.Property(p => p.Bairro).HasColumnName("bairro").HasColumnType("varchar(60)").IsRequired();
            builder.Property(p => p.Municipio).HasColumnName("municipio").HasColumnType("varchar(60)").IsRequired();
            builder.Property(p => p.Uf).HasColumnName("uf").HasColumnType("char(2)").IsRequired();
            builder.Property(p => p.Cep).HasColumnName("cep").HasColumnType("char(8)").IsRequired();
            builder.Property(p => p.EnderecoCobranca).HasColumnName("endereco_cobranca").HasColumnType("bit").HasDefaultValue(0).IsRequired();
            builder.Property(p => p.EnderecoEntrega).HasColumnName("endereco_entrega").HasColumnType("bit").HasDefaultValue(0).IsRequired();
            builder.Property(p => p.EnderecoServico).HasColumnName("endereco_servico").HasColumnType("bit").HasDefaultValue(0).IsRequired();

            builder.HasOne(p => p.Cliente).WithMany(p => p.Enderecos).HasForeignKey(p => p.ClienteId);

        }
    }
}
