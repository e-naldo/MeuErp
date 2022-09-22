using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MeuErp.Data.Migrations
{
    public partial class CreateTableEquipamentoTipoMarcaModole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    modelo_equipamento_id = table.Column<int>(type: "int", nullable: true),
                    cliente_id = table.Column<int>(type: "int", nullable: false),
                    endereco_id = table.Column<int>(type: "int", nullable: true),
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
                        name: "FK_equipamento_endereco_endereco_id",
                        column: x => x.endereco_id,
                        principalTable: "endereco",
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
                });

            migrationBuilder.CreateIndex(
                name: "IX_equipamento_cliente_id",
                table: "equipamento",
                column: "cliente_id");

            migrationBuilder.CreateIndex(
                name: "IX_equipamento_endereco_id",
                table: "equipamento",
                column: "endereco_id");

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
                name: "IX_modelo_equipamento_MarcaEquipamentoId",
                table: "modelo_equipamento",
                column: "MarcaEquipamentoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "equipamento");

            migrationBuilder.DropTable(
                name: "modelo_equipamento");

            migrationBuilder.DropTable(
                name: "tipo_equipamento");

            migrationBuilder.DropTable(
                name: "marca_equipamento");
        }
    }
}
