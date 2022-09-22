﻿// <auto-generated />
using System;
using MeuErp.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MeuErp.Data.Migrations
{
    [DbContext(typeof(MeuErpDbContext))]
    [Migration("20220919165122_CreateTableClienteEndereco")]
    partial class CreateTableClienteEndereco
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("MeuErp.Business.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime2")
                        .HasColumnName("data_cadastro");

                    b.Property<string>("Documento")
                        .IsRequired()
                        .HasColumnType("varchar(14)")
                        .HasColumnName("documento");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(150)")
                        .HasColumnName("email");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(150)")
                        .HasColumnName("nome");

                    b.Property<string>("Site")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasColumnName("site");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("varchar(14)")
                        .HasColumnName("telefone");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnType("char(1)")
                        .HasColumnName("tipo");

                    b.HasKey("Id");

                    b.ToTable("cliente", (string)null);
                });

            modelBuilder.Entity("MeuErp.Business.Models.Endereco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("varchar(60)")
                        .HasColumnName("bairro");

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasColumnType("char(8)")
                        .HasColumnName("cep");

                    b.Property<int>("ClienteId")
                        .HasColumnType("int")
                        .HasColumnName("cliente_id");

                    b.Property<string>("Complemento")
                        .HasColumnType("varchar(60)")
                        .HasColumnName("complemento");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("varchar(60)")
                        .HasColumnName("descricao");

                    b.Property<bool>("EnderecoCobranca")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false)
                        .HasColumnName("endereco_cobranca");

                    b.Property<bool>("EnderecoEntrega")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false)
                        .HasColumnName("endereco_entrega");

                    b.Property<bool>("EnderecoServico")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false)
                        .HasColumnName("endereco_servico");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasColumnType("varchar(60)")
                        .HasColumnName("logradouro");

                    b.Property<string>("Municipio")
                        .IsRequired()
                        .HasColumnType("varchar(60)")
                        .HasColumnName("municipio");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasColumnType("varchar(10)")
                        .HasColumnName("numero");

                    b.Property<string>("Uf")
                        .IsRequired()
                        .HasColumnType("char(2)")
                        .HasColumnName("uf");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.ToTable("endereco", (string)null);
                });

            modelBuilder.Entity("MeuErp.Business.Models.Endereco", b =>
                {
                    b.HasOne("MeuErp.Business.Models.Cliente", "Cliente")
                        .WithMany("Enderecos")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("MeuErp.Business.Models.Cliente", b =>
                {
                    b.Navigation("Enderecos");
                });
#pragma warning restore 612, 618
        }
    }
}
