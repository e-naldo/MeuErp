using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuErp.Business.Models
{
    public class ModeloEquipamento : EntidadeBase
    {
        public int MarcaEquipamentoId { get; set; }
        public string Nome { get; set; } = string.Empty;

        public MarcaEquipamento MarcaEquipamento { get; set; } = null!;

        public IList<Equipamento> Equipamentos { get; set; } = new List<Equipamento>();


    }
}
