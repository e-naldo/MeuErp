using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MeuErp.Data.Migrations
{
    public partial class CreateTableOsTipoSituacaoItemProdutoServico : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "item_produto_os");

            migrationBuilder.DropTable(
                name: "item_servico_os");

            migrationBuilder.DropTable(
                name: "os");

            migrationBuilder.DropTable(
                name: "situacao_os");

            migrationBuilder.DropTable(
                name: "tipo_os");
        }
    }
}
