using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.Presentation.Api.Models
{
    public class EnderecoCadastroModel
    {
        [Required(ErrorMessage = "Informe o logradouro.")]
        [MaxLength(50)]
        public string Logradouro { get; set; }

        [Required(ErrorMessage = "Informe o bairro.")]
        [MaxLength(40)]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "Informe a cidade.")]
        [MaxLength(40)]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "Informe o estado.")]
        [MaxLength(40)]
        public string Estado { get; set; }
    }
}
