using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.Application.Models
{
    public class ClienteEdicaoModel
    {
        [Required(ErrorMessage = "Informe o id do cliente.")]
        public string IdCliente { get; set; }

        [Required(ErrorMessage = "Informe o nome.")]
        [MaxLength(30)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe o cpf.")]
        [MaxLength(11)]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "Informe a idade.")]
        public int Idade { get; set; }

        [Required(ErrorMessage = "Informe a data de nascimento.")]
        public DateTime DataNascimento { get; set; }
    }
}
