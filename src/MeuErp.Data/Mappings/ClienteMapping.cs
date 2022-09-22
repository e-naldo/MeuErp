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
    public class ClienteMapping : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("cliente");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).HasColumnName("id");
            builder.Property(p => p.Nome).HasColumnName("nome").HasColumnType("varchar(150)").IsRequired();
            builder.Property(p => p.Tipo).HasColumnName("tipo").HasColumnType("char(1)").IsRequired();
            builder.Property(p => p.Documento).HasColumnName("documento").HasColumnType("varchar(14)").IsRequired();
            builder.Property(p => p.Email).HasColumnName("email").HasColumnType("varchar(150)");
            builder.Property(p => p.Site).HasColumnName("site").HasColumnType("varchar(255)");
            builder.Property(p => p.Telefone).HasColumnName("telefone").HasColumnType("varchar(14)");
            builder.Property(p => p.DataCadastro).HasColumnName("data_cadastro").HasColumnType("datetime2").IsRequired();

            builder.HasMany(p => p.Enderecos).WithOne(p => p.Cliente).OnDelete(DeleteBehavior.Cascade);


        }
    }
}
