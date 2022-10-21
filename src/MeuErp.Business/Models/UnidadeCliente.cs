using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuErp.Business.Models
{
    public class UnidadeCliente : EntidadeBase
    {
        public int ClienteId { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string? Responsavel { get; set; }
        public string? Telefone { get; set; }
        public string? Celular { get; set; }
        public bool CelularWhatsapp { get; set; }
        public string? Email { get; set; }
        public string Logradouro { get; set; } = string.Empty;
        public string Numero { get; set; } = string.Empty;
        public string? Complemento { get; set; }
        public string Bairro { get; set; } = string.Empty;
        public string Municipio { get; set; } = string.Empty;
        public string Uf { get; set; } = string.Empty;
        public string Cep { get; set; } = string.Empty;


        public Cliente Cliente { get; set; } = null!;
        public IList<Equipamento> Equipamentos { get; set; } = new List<Equipamento>();


    }
}
