using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuErp.Business.Models
{
    public class TipoEquipamento : EntidadeBase
    {
        public string Nome { get; set; } = string.Empty;

        public IList<Equipamento> Equipamentos { get; set; } = new List<Equipamento>();

    }
}
