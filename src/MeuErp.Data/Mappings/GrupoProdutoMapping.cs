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
    public class GrupoProdutoMapping : IEntityTypeConfiguration<GrupoProduto>
    {
        public void Configure(EntityTypeBuilder<GrupoProduto> builder)
        {
            builder.ToTable("grupo_produto");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id).HasColumnName("id");
            builder.Property(p => p.Nome).HasColumnName("nome").HasColumnType("varchar(50)").IsRequired();

        }
    }
}
