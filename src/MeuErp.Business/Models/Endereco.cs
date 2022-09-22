using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuErp.Business.Models
{
    public class Endereco : EntidadeBase
    {
        public int ClienteId { get; set; }
        public string Descricao { get; set; } = string.Empty;
        public string Logradouro { get; set; } = string.Empty;
        public string Numero { get; set; } = string.Empty;
        public string? Complemento { get; set; }
        public string Bairro { get; set; } = string.Empty;
        public string Municipio { get; set; } = string.Empty;
        public string Uf { get; set; } = string.Empty;
        public string Cep { get; set; } = string.Empty;
        public bool EnderecoCobranca { get; set; }
        public bool EnderecoEntrega { get; set; }
        public bool EnderecoServico { get; set; }

        public Cliente Cliente { get; set; } = null!;
        public IList<Equipamento> Equipamentos { get; set; } = new List<Equipamento>();


    }
}
