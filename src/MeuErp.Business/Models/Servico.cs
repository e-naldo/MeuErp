using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuErp.Business.Models
{
    public class Servico : EntidadeBase
    {
        public string? Referencia { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
        public decimal Preco { get; set; }

        public IList<ItemServicoOs> Itens { get; set; } = new List<ItemServicoOs>();
    }
}
