using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuErp.Business.Models
{
    public class GrupoProduto : EntidadeBase
    {
        public string Nome { get; set; } = string.Empty;

        public IList<Produto> Produtos { get; set; } = new List<Produto>();
    }
}
