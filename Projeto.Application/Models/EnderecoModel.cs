using System;
using System.ComponentModel.DataAnnotations;

namespace Projeto.Application.Models
{
    public class EnderecoModel
    {
        public EnderecoModel()
        {
            IdEndereco = Guid.NewGuid();
        }
        [Key]
        public Guid IdEndereco { get; set; }

        [Required(ErrorMessage = "Preencha o campo Logradouro")]
        [MaxLength(50, ErrorMessage = "Máximo {0} caracteres")]
        public string Logradouro { get; set; }

        [Required(ErrorMessage = "Preencha o campo Bairro")]
        [MaxLength(40, ErrorMessage = "Máximo {0} caracteres")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "Preencha o campo Cidade")]
        [MaxLength(40, ErrorMessage = "Máximo {0} caracteres")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "Preencha o campo Estado")]
        [MaxLength(40, ErrorMessage = "Máximo {0} caracteres")]
        public string Estado { get; set; }

        [ScaffoldColumn(false)]
        public Guid IdCliente { get; set; }
    }
}
