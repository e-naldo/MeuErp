using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuErp.Business.Models
{
    public class ItemServicoOs : EntidadeBase
    {
        public int OsId { get; set; }
        public int ServicoId { get; set; }
        public decimal Quantidade { get; set; }
        public decimal ValorUnitario { get; set; }
        public decimal ValorSubtotal { get; set; }
        public decimal TaxaDesconto { get; set; }
        public decimal ValorDesconto { get; set; }
        public decimal ValorTotal { get; set; }

        public Os Os { get; set; } = null!;
        public Servico Servico { get; set; } = null!;

    }
}
