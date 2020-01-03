using System.ComponentModel.DataAnnotations;

namespace Projeto.Application.Models
{
    public class EnderecoEdicaoModel
    {
        [Required(ErrorMessage = "Informe o id do endereco.")]
        public string IdEndereco { get; set; }

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

        public string IdCliente { get; set; }
    }
}
