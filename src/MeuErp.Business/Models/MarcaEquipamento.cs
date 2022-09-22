using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuErp.Business.Models
{
    public class MarcaEquipamento : EntidadeBase
    {
        public string Nome { get; set; } = string.Empty;

        public IList<ModeloEquipamento> ModelosEquipamentos { get; set; } = new List<ModeloEquipamento>();
        public IList<Equipamento> Equipamentos { get; set; } = new List<Equipamento>();
    }
}
