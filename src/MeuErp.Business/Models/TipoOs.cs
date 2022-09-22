using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuErp.Business.Models
{
    public class TipoOs : EntidadeBase
    {
        public string Nome { get; set; } = string.Empty;
        public string? Descricao { get; set; }

        public IList<Os> Oss { get; set; } = new List<Os>();

    }
}
