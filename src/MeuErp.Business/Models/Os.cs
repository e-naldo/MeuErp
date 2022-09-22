using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuErp.Business.Models
{
    public class Os : EntidadeBase
    {
        public int ClienteId { get; set; }
        public int EquipamentoId { get; set; }
        public int TipoOsId { get; set; }
        public int SituacaoOsId { get; set; }
        public decimal ValorTotal { get; set; }
        public string FormaPagamento { get; set; } = string.Empty;
        public string? Observacao { get; set; }


        public Cliente Cliente { get; set; } = null!;
        public Equipamento Equipamento { get; set; } = null!;
        public TipoOs TipoOs { get; set; } = null!;
        public SituacaoOs SituacaoOs { get; set; } = null!;

        public IList<ItemProdutoOs> ItensProdutos { get; set; } = new List<ItemProdutoOs>();
        public IList<ItemServicoOs> ItensServicos { get; set; } = new List<ItemServicoOs>();


    }
}
