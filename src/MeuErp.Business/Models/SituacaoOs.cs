using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuErp.Business.Models
{
    public class SituacaoOs : EntidadeBase
    {
        public string Nome { get; set; } = string.Empty;

        public IList<Os> Oss { get; set; } = new List<Os>();

    }
}
