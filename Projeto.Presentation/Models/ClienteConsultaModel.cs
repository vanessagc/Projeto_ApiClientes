using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.Presentation.Api.Models
{
    public class ClienteConsultaModel
    {
        public string IdCliente { get; set; }
        public string Nome { get; set; }

        public string Cpf { get; set; }

        public int Idade { get; set; }

        public DateTime DataNascimento { get; set; }

        public List<EnderecoCadastroModel> Enderecos { get; set; }
 
    }
}
