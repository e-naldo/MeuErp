using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MeuErp.Data.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "cliente",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "varchar(150)", nullable: false),
                    tipo = table.Column<string>(type: "char(1)", nullable: false),
                    documento = table.Column<string>(type: "varchar(14)", nullable: false),
                    email = table.Column<string>(type: "varchar(150)", nullable: true),
                    site = table.Column<string>(type: "varchar(255)", nullable: true),
                    telefone = table.Column<string>(type: "varchar(14)", nullable: true),
                    data_cadastro = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cliente", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "grupo_produto",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_grupo_produto", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "marca_equipamento",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "varchar(60)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_marca_equipamento", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "servico",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    referencia = table.Column<string>(type: "varchar(20)", nullable: true),
                    nome = table.Column<string>(type: "varchar(150)", nullable: false),
                    descricao = table.Column<string>(type: "varchar(max)", nullable: false),
                    preco = table.Column<decimal>(type: "decimal(18,6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_servico", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "situacao_os",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_situacao_os", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tipo_equipamento",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tipo_equipamento", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tipo_os",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "varchar(100)", nullable: false),
                    descricao = table.Column<string>(type: "varchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tipo_os", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "endereco",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cliente_id = table.Column<int>(type: "int", nullable: false),
                    logradouro = table.Column<string>(type: "varchar(60)", nullable: false),
                    numero = table.Column<string>(type: "varchar(10)", nullable: false),
                    complemento = table.Column<string>(type: "varchar(60)", nullable: true),
                    bairro = table.Column<string>(type: "varchar(60)", nullable: false),
                    municipio = table.Column<string>(type: "varchar(60)", nullable: false),
                    uf = table.Column<string>(type: "char(2)", nullable: false),
                    cep = table.Column<string>(type: "char(8)", nullable: false),
                    endereco_cobranca = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    endereco_entrega = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_endereco", x => x.id);
                    table.ForeignKey(
                        name: "FK_endereco_cliente_cliente_id",
                        column: x => x.cliente_id,
                        principalTable: "cliente",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "unidade_cliente",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cliente_id = table.Column<int>(type: "int", nullable: false),
                    nome = table.Column<string>(type: "varchar(60)", nullable: false),
                    responsavel = table.Column<string>(type: "varchar(100)", nullable: true),
                    telefone = table.Column<string>(type: "varchar(14)", nullable: true),
                    celular = table.Column<string>(type: "varchar(14)", nullable: true),
                    celular_whatsapp = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    email = table.Column<string>(type: "varchar(150)", nullable: true),
                    logradouro = table.Column<string>(type: "varchar(60)", nullable: false),
                    numero = table.Column<string>(type: "varchar(10)", nullable: false),
                    complemento = table.Column<string>(type: "varchar(60)", nullable: true),
                    bairro = table.Column<string>(type: "varchar(60)", nullable: false),
                    municipio = table.Column<string>(type: "varchar(60)", nullable: false),
                    uf = table.Column<string>(type: "char(2)", nullable: false),
                    cep = table.Column<string>(type: "char(8)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_unidade_cliente", x => x.id);
                    table.ForeignKey(
                        name: "FK_unidade_cliente_cliente_cliente_id",
                        column: x => x.cliente_id,
                        principalTable: "cliente",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "produto",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    grupo_produto_id = table.Column<int>(type: "int", nullable: true),
                    referencia = table.Column<string>(type: "varchar(20)", nullable: true),
                    nome = table.Column<string>(type: "varchar(150)", nullable: false),
                    descricao = table.Column<string>(type: "varchar(max)", nullable: false),
                    unidade = table.Column<string>(type: "varchar(4)", nullable: false),
                    preco_compra = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    preco_venda = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    preco_maximo = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    preco_minimo = table.Column<decimal>(type: "decimal(18,6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_produto", x => x.id);
                    table.ForeignKey(
                        name: "FK_produto_grupo_produto_grupo_produto_id",
                        column: x => x.grupo_produto_id,
                        principalTable: "grupo_produto",
                        principalColumn: "id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "modelo_equipamento",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MarcaEquipamentoId = table.Column<int>(type: "int", nullable: false),
                    nome = table.Column<string>(type: "varchar(60)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_modelo_equipamento", x => x.id);
                    table.ForeignKey(
                        name: "FK_modelo_equipamento_marca_equipamento_MarcaEquipamentoId",
                        column: x => x.MarcaEquipamentoId,
                        principalTable: "marca_equipamento",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "equipamento",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tipo_equipamento_id = table.Column<int>(type: "int", nullable: false),
                    marca_equipamento_id = table.Column<int>(type: "int", nullable: false),
                    modelo_equipamento_id = table.Column<int>(type: "int", nullable: false),
                    cliente_id = table.Column<int>(type: "int", nullable: false),
                    unidade_cliente_id = table.Column<int>(type: "int", nullable: false),
                    numero_serie = table.Column<string>(type: "varchar(50)", nullable: false),
                    numero_lote = table.Column<string>(type: "varchar(20)", nullable: true),
                    data_fabricacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    data_fim_garantia = table.Column<DateTime>(type: "datetime2", nullable: true),
                    data_cadastro = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    observacao = table.Column<string>(type: "varchar", nullable: true),
                    inativo = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_equipamento", x => x.id);
                    table.ForeignKey(
                        name: "FK_equipamento_cliente_cliente_id",
                        column: x => x.cliente_id,
                        principalTable: "cliente",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_equipamento_marca_equipamento_marca_equipamento_id",
                        column: x => x.marca_equipamento_id,
                        principalTable: "marca_equipamento",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_equipamento_modelo_equipamento_modelo_equipamento_id",
                        column: x => x.modelo_equipamento_id,
                        principalTable: "modelo_equipamento",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_equipamento_tipo_equipamento_tipo_equipamento_id",
                        column: x => x.tipo_equipamento_id,
                        principalTable: "tipo_equipamento",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_equipamento_unidade_cliente_unidade_cliente_id",
                        column: x => x.unidade_cliente_id,
                        principalTable: "unidade_cliente",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "os",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cliente_id = table.Column<int>(type: "int", nullable: false),
                    equipamento_id = table.Column<int>(type: "int", nullable: false),
                    tipo_os_id = table.Column<int>(type: "int", nullable: false),
                    situacao_os_id = table.Column<int>(type: "int", nullable: false),
                    valor_total = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    forma_pagamento = table.Column<string>(type: "varchar(50)", nullable: false),
                    observacao = table.Column<string>(type: "varchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_os", x => x.id);
                    table.ForeignKey(
                        name: "FK_os_cliente_cliente_id",
                        column: x => x.cliente_id,
                        principalTable: "cliente",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_os_equipamento_equipamento_id",
                        column: x => x.equipamento_id,
                        principalTable: "equipamento",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_os_situacao_os_situacao_os_id",
                        column: x => x.situacao_os_id,
                        principalTable: "situacao_os",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_os_tipo_os_tipo_os_id",
                        column: x => x.tipo_os_id,
                        principalTable: "tipo_os",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "item_produto_os",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    os_id = table.Column<int>(type: "int", nullable: false),
                    produto_id = table.Column<int>(type: "int", nullable: false),
                    quantidade = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    valor_unitario = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    valor_subtotal = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    taxa_desconto = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    valor_desconto = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    valor_total = table.Column<decimal>(type: "decimal(18,6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_item_produto_os", x => x.id);
                    table.ForeignKey(
                        name: "FK_item_produto_os_os_os_id",
                        column: x => x.os_id,
                        principalTable: "os",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_item_produto_os_produto_produto_id",
                        column: x => x.produto_id,
                        principalTable: "produto",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "item_servico_os",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    os_id = table.Column<int>(type: "int", nullable: false),
                    servico_id = table.Column<int>(type: "int", nullable: false),
                    quantidade = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    valor_unitario = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    valor_subtotal = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    taxa_desconto = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    valor_desconto = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    valor_total = table.Column<decimal>(type: "decimal(18,6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_item_servico_os", x => x.id);
                    table.ForeignKey(
                        name: "FK_item_servico_os_os_os_id",
                        column: x => x.os_id,
                        principalTable: "os",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_item_servico_os_servico_servico_id",
                        column: x => x.servico_id,
                        principalTable: "servico",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_endereco_cliente_id",
                table: "endereco",
                column: "cliente_id");

            migrationBuilder.CreateIndex(
                name: "IX_equipamento_cliente_id",
                table: "equipamento",
                column: "cliente_id");

            migrationBuilder.CreateIndex(
                name: "IX_equipamento_marca_equipamento_id",
                table: "equipamento",
                column: "marca_equipamento_id");

            migrationBuilder.CreateIndex(
                name: "IX_equipamento_modelo_equipamento_id",
                table: "equipamento",
                column: "modelo_equipamento_id");

            migrationBuilder.CreateIndex(
                name: "IX_equipamento_tipo_equipamento_id",
                table: "equipamento",
                column: "tipo_equipamento_id");

            migrationBuilder.CreateIndex(
                name: "IX_equipamento_unidade_cliente_id",
                table: "equipamento",
                column: "unidade_cliente_id");

            migrationBuilder.CreateIndex(
                name: "IX_item_produto_os_os_id",
                table: "item_produto_os",
                column: "os_id");

            migrationBuilder.CreateIndex(
                name: "IX_item_produto_os_produto_id",
                table: "item_produto_os",
                column: "produto_id");

            migrationBuilder.CreateIndex(
                name: "IX_item_servico_os_os_id",
                table: "item_servico_os",
                column: "os_id");

            migrationBuilder.CreateIndex(
                name: "IX_item_servico_os_servico_id",
                table: "item_servico_os",
                column: "servico_id");

            migrationBuilder.CreateIndex(
                name: "IX_modelo_equipamento_MarcaEquipamentoId",
                table: "modelo_equipamento",
                column: "MarcaEquipamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_os_cliente_id",
                table: "os",
                column: "cliente_id");

            migrationBuilder.CreateIndex(
                name: "IX_os_equipamento_id",
                table: "os",
                column: "equipamento_id");

            migrationBuilder.CreateIndex(
                name: "IX_os_situacao_os_id",
                table: "os",
                column: "situacao_os_id");

            migrationBuilder.CreateIndex(
                name: "IX_os_tipo_os_id",
                table: "os",
                column: "tipo_os_id");

            migrationBuilder.CreateIndex(
                name: "IX_produto_grupo_produto_id",
                table: "produto",
                column: "grupo_produto_id");

            migrationBuilder.CreateIndex(
                name: "IX_unidade_cliente_cliente_id",
                table: "unidade_cliente",
                column: "cliente_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "endereco");

            migrationBuilder.DropTable(
                name: "item_produto_os");

            migrationBuilder.DropTable(
                name: "item_servico_os");

            migrationBuilder.DropTable(
                name: "produto");

            migrationBuilder.DropTable(
                name: "os");

            migrationBuilder.DropTable(
                name: "servico");

            migrationBuilder.DropTable(
                name: "grupo_produto");

            migrationBuilder.DropTable(
                name: "equipamento");

            migrationBuilder.DropTable(
                name: "situacao_os");

            migrationBuilder.DropTable(
                name: "tipo_os");

            migrationBuilder.DropTable(
                name: "modelo_equipamento");

            migrationBuilder.DropTable(
                name: "tipo_equipamento");

            migrationBuilder.DropTable(
                name: "unidade_cliente");

            migrationBuilder.DropTable(
                name: "marca_equipamento");

            migrationBuilder.DropTable(
                name: "cliente");
        }
    }
}
