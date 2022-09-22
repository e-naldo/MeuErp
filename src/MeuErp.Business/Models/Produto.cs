using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuErp.Business.Models
{
    public class Produto : EntidadeBase
    {
        public int? GrupoProdutoId { get; set; }
        public string? Referencia { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
        public string Unidade { get; set; } = string.Empty;
        public decimal PrecoCompra { get; set; }
        public decimal PrecoVenda { get; set; }
        public decimal PrecoMaximo { get; set; }
        public decimal PrecoMinimo { get; set; }

        public GrupoProduto? GrupoProduto { get; set; }

        public IList<ItemProdutoOs> Itens { get; set; } = new List<ItemProdutoOs>();

    }
}
