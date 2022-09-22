using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MeuErp.Data.Migrations
{
    public partial class CreateTableClienteEndereco : Migration
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
                    email = table.Column<string>(type: "varchar(150)", nullable: false),
                    site = table.Column<string>(type: "varchar(255)", nullable: false),
                    telefone = table.Column<string>(type: "varchar(14)", nullable: false),
                    data_cadastro = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cliente", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "endereco",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cliente_id = table.Column<int>(type: "int", nullable: false),
                    descricao = table.Column<string>(type: "varchar(60)", nullable: false),
                    logradouro = table.Column<string>(type: "varchar(60)", nullable: false),
                    numero = table.Column<string>(type: "varchar(10)", nullable: false),
                    complemento = table.Column<string>(type: "varchar(60)", nullable: true),
                    bairro = table.Column<string>(type: "varchar(60)", nullable: false),
                    municipio = table.Column<string>(type: "varchar(60)", nullable: false),
                    uf = table.Column<string>(type: "char(2)", nullable: false),
                    cep = table.Column<string>(type: "char(8)", nullable: false),
                    endereco_cobranca = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    endereco_entrega = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    endereco_servico = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
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

            migrationBuilder.CreateIndex(
                name: "IX_endereco_cliente_id",
                table: "endereco",
                column: "cliente_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "endereco");

            migrationBuilder.DropTable(
                name: "cliente");
        }
    }
}
