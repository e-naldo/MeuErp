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
    [Migration("20220921195718_CreateTableEquipamentoTipoMarcaModole")]
    partial class CreateTableEquipamentoTipoMarcaModole
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
                        .HasColumnType("varchar(150)")
                        .HasColumnName("email");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(150)")
                        .HasColumnName("nome");

                    b.Property<string>("Site")
                        .HasColumnType("varchar(255)")
                        .HasColumnName("site");

                    b.Property<string>("Telefone")
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

            modelBuilder.Entity("MeuErp.Business.Models.Equipamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ClienteId")
                        .HasColumnType("int")
                        .HasColumnName("cliente_id");

                    b.Property<DateTime>("DataCadastro")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasColumnName("data_cadastro")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<DateTime?>("DataFabricacao")
                        .HasColumnType("datetime2")
                        .HasColumnName("data_fabricacao");

                    b.Property<DateTime?>("DataFimGarantia")
                        .HasColumnType("datetime2")
                        .HasColumnName("data_fim_garantia");

                    b.Property<int?>("EnderecoId")
                        .HasColumnType("int")
                        .HasColumnName("endereco_id");

                    b.Property<bool>("Inativo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false)
                        .HasColumnName("inativo");

                    b.Property<int>("MarcaEquipamentoId")
                        .HasColumnType("int")
                        .HasColumnName("marca_equipamento_id");

                    b.Property<int>("ModeloEquipamentoId")
                        .HasColumnType("int")
                        .HasColumnName("modelo_equipamento_id");

                    b.Property<string>("NumeroLote")
                        .HasColumnType("varchar(20)")
                        .HasColumnName("numero_lote");

                    b.Property<string>("NumeroSerie")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasColumnName("numero_serie");

                    b.Property<string>("Observacao")
                        .HasColumnType("varchar")
                        .HasColumnName("observacao");

                    b.Property<int>("TipoEquipamentoId")
                        .HasColumnType("int")
                        .HasColumnName("tipo_equipamento_id");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("EnderecoId");

                    b.HasIndex("MarcaEquipamentoId");

                    b.HasIndex("ModeloEquipamentoId");

                    b.HasIndex("TipoEquipamentoId");

                    b.ToTable("equipamento", (string)null);
                });

            modelBuilder.Entity("MeuErp.Business.Models.GrupoProduto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasColumnName("nome");

                    b.HasKey("Id");

                    b.ToTable("grupo_produto", (string)null);
                });

            modelBuilder.Entity("MeuErp.Business.Models.MarcaEquipamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(60)")
                        .HasColumnName("nome");

                    b.HasKey("Id");

                    b.ToTable("marca_equipamento", (string)null);
                });

            modelBuilder.Entity("MeuErp.Business.Models.ModeloEquipamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("MarcaEquipamentoId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(60)")
                        .HasColumnName("nome");

                    b.HasKey("Id");

                    b.HasIndex("MarcaEquipamentoId");

                    b.ToTable("modelo_equipamento", (string)null);
                });

            modelBuilder.Entity("MeuErp.Business.Models.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("varchar(max)")
                        .HasColumnName("descricao");

                    b.Property<int?>("GrupoProdutoId")
                        .HasColumnType("int")
                        .HasColumnName("grupo_produto_id");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(150)")
                        .HasColumnName("nome");

                    b.Property<decimal>("PrecoCompra")
                        .HasColumnType("decimal(18,6)")
                        .HasColumnName("preco_compra");

                    b.Property<decimal>("PrecoMaximo")
                        .HasColumnType("decimal(18,6)")
                        .HasColumnName("preco_maximo");

                    b.Property<decimal>("PrecoMinimo")
                        .HasColumnType("decimal(18,6)")
                        .HasColumnName("preco_minimo");

                    b.Property<decimal>("PrecoVenda")
                        .HasColumnType("decimal(18,6)")
                        .HasColumnName("preco_venda");

                    b.Property<string>("Referencia")
                        .HasColumnType("varchar(20)")
                        .HasColumnName("referencia");

                    b.Property<string>("Unidade")
                        .IsRequired()
                        .HasColumnType("varchar(4)")
                        .HasColumnName("unidade");

                    b.HasKey("Id");

                    b.HasIndex("GrupoProdutoId");

                    b.ToTable("produto", (string)null);
                });

            modelBuilder.Entity("MeuErp.Business.Models.Servico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("varchar(max)")
                        .HasColumnName("descricao");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(150)")
                        .HasColumnName("nome");

                    b.Property<decimal>("Preco")
                        .HasColumnType("decimal(18,6)")
                        .HasColumnName("preco");

                    b.Property<string>("Referencia")
                        .HasColumnType("varchar(20)")
                        .HasColumnName("referencia");

                    b.HasKey("Id");

                    b.ToTable("servico", (string)null);
                });

            modelBuilder.Entity("MeuErp.Business.Models.TipoEquipamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("nome");

                    b.HasKey("Id");

                    b.ToTable("tipo_equipamento", (string)null);
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

            modelBuilder.Entity("MeuErp.Business.Models.Equipamento", b =>
                {
                    b.HasOne("MeuErp.Business.Models.Cliente", "Cliente")
                        .WithMany("Equipamentos")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("MeuErp.Business.Models.Endereco", "Endereco")
                        .WithMany("Equipamentos")
                        .HasForeignKey("EnderecoId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("MeuErp.Business.Models.MarcaEquipamento", "MarcaEquipamento")
                        .WithMany("Equipamentos")
                        .HasForeignKey("MarcaEquipamentoId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("MeuErp.Business.Models.ModeloEquipamento", "ModeloEquipamento")
                        .WithMany("Equipamentos")
                        .HasForeignKey("ModeloEquipamentoId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("MeuErp.Business.Models.TipoEquipamento", "TipoEquipamento")
                        .WithMany("Equipamentos")
                        .HasForeignKey("TipoEquipamentoId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("Endereco");

                    b.Navigation("MarcaEquipamento");

                    b.Navigation("ModeloEquipamento");

                    b.Navigation("TipoEquipamento");
                });

            modelBuilder.Entity("MeuErp.Business.Models.ModeloEquipamento", b =>
                {
                    b.HasOne("MeuErp.Business.Models.MarcaEquipamento", "MarcaEquipamento")
                        .WithMany("ModelosEquipamentos")
                        .HasForeignKey("MarcaEquipamentoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MarcaEquipamento");
                });

            modelBuilder.Entity("MeuErp.Business.Models.Produto", b =>
                {
                    b.HasOne("MeuErp.Business.Models.GrupoProduto", "GrupoProduto")
                        .WithMany("Produtos")
                        .HasForeignKey("GrupoProdutoId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("GrupoProduto");
                });

            modelBuilder.Entity("MeuErp.Business.Models.Cliente", b =>
                {
                    b.Navigation("Enderecos");

                    b.Navigation("Equipamentos");
                });

            modelBuilder.Entity("MeuErp.Business.Models.Endereco", b =>
                {
                    b.Navigation("Equipamentos");
                });

            modelBuilder.Entity("MeuErp.Business.Models.GrupoProduto", b =>
                {
                    b.Navigation("Produtos");
                });

            modelBuilder.Entity("MeuErp.Business.Models.MarcaEquipamento", b =>
                {
                    b.Navigation("Equipamentos");

                    b.Navigation("ModelosEquipamentos");
                });

            modelBuilder.Entity("MeuErp.Business.Models.ModeloEquipamento", b =>
                {
                    b.Navigation("Equipamentos");
                });

            modelBuilder.Entity("MeuErp.Business.Models.TipoEquipamento", b =>
                {
                    b.Navigation("Equipamentos");
                });
#pragma warning restore 612, 618
        }
    }
}