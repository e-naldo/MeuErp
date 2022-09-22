using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuErp.Business.Models
{
    public class Cliente : EntidadeBase
    {
        public string Nome { get; set; } = string.Empty;
        public string Tipo { get; set; } = string.Empty;
        public string Documento { get; set; } = string.Empty;
        public string? Email { get; set; }
        public string? Site { get; set; }
        public string? Telefone { get; set; }
        public DateTime DataCadastro { get; set; }

        public IList<Endereco> Enderecos { get; set; } = new List<Endereco>();
        public IList<Equipamento> Equipamentos { get; set; } = new List<Equipamento>();
        public IList<Os> Oss { get; set; } = new List<Os>();




    }
}
