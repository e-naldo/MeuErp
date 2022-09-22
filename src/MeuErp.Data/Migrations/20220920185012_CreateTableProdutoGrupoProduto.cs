using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MeuErp.Data.Migrations
{
    public partial class CreateTableProdutoGrupoProduto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateIndex(
                name: "IX_produto_grupo_produto_id",
                table: "produto",
                column: "grupo_produto_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "produto");

            migrationBuilder.DropTable(
                name: "grupo_produto");
        }
    }
}
