using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuErp.Business.Models
{
    public class Equipamento : EntidadeBase
    {
        public int TipoEquipamentoId { get; set; }
        public int MarcaEquipamentoId { get; set; }
        public int ModeloEquipamentoId { get; set; }
        public int ClienteId { get; set; }
        public int? EnderecoId { get; set; }
        public string NumeroSerie { get; set; } = string.Empty;
        public string? NumeroLote { get; set; }
        public DateTime? DataFabricacao { get; set; }
        public DateTime? DataFimGarantia { get; set; }
        public DateTime DataCadastro { get; set; }
        public string? Observacao { get; set; }
        public bool Inativo { get; set; }

        public TipoEquipamento TipoEquipamento { get; set; } = null!;
        public MarcaEquipamento MarcaEquipamento { get; set; } = null!;
        public ModeloEquipamento ModeloEquipamento { get; set; } = null!;
        public Cliente Cliente { get; set; } = null!;
        public Endereco? Endereco { get; set; }
        public IList<Os> Oss { get; set; } = new List<Os>();

    }
}
