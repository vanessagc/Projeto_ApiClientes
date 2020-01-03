using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.Application.Models
{
    public class ClienteModel
    {
        public ClienteModel()
        {
            IdCliente = Guid.NewGuid();
            Enderecos = new List<EnderecoModel>();
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
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        [DataType(DataType.Date, ErrorMessage = "Data em formato inválido")]
        public DateTime DataNascimento { get; set; }

        public ICollection<EnderecoModel> Enderecos { get; set; }

    }
}
