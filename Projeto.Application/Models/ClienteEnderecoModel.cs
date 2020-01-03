using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Projeto.Application.Models
{
    public class ClienteEnderecoModel
    {
        public ClienteEnderecoModel()
        {
            IdCliente = Guid.NewGuid();
            IdEndereco = Guid.NewGuid();
        }

        [Key]
        public Guid IdCliente { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome")]
        [MaxLength(30, ErrorMessage = "Máximo {0} caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome")]
        [MaxLength(11, ErrorMessage = "Máximo {0} caracteres")]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "Preencha o campo idade.")]
        public int Idade { get; set; }

        [Display(Name = "Data de Nascimento")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [DataType(DataType.Date, ErrorMessage = "Data em formato inválido")]
        public DateTime DataNascimento { get; set; }

        public ICollection<EnderecoModel> Enderecos { get; set; }

        // Endereços

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

    

    }
}
