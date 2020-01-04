using FluentValidation;
using Projeto.Domain.Entities;
using Projeto.Domain.Specifications;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Domain.Validations
{
    public class EnderecoEhValido : AbstractValidator<Endereco>
    {
        public EnderecoEhValido()
        {

            RuleSet("all", () =>
            {
                RuleFor(x => x.Logradouro).NotNull().WithMessage("Logradouro obrigatório");
                RuleFor(x => x.Bairro).NotNull().WithMessage("Bairro obrigatório");
                RuleFor(x => x.Cidade).NotNull().WithMessage("Cidade obrigatório");
                RuleFor(x => x.Estado).NotNull().WithMessage("Estado obrigatório");
            });

        }
    }
}
