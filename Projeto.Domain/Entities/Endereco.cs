using FluentValidation.Results;
using Projeto.Domain.Validations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Domain.Entities
{
    public class Endereco
    {
        public Endereco()
        {
            IdEndereco = Guid.NewGuid();
        }
        public Guid IdEndereco { get; set; }

        public string Logradouro { get; set; }

        public string Bairro { get; set; }

        public string Cidade { get; set; }

        public string Estado { get; set; }

        public Guid IdCliente { get; set; }

        public virtual Cliente Cliente { get; set; }


    }
}
