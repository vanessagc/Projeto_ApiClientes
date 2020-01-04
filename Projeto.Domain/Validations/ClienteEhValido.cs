using FluentValidation;
using Projeto.Domain.Entities;
using Projeto.Domain.Specifications;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Domain.Validations
{
    public class ClienteEhValido : AbstractValidator<Cliente>
    {
        public ClienteEhValido()
        {

            var CPFCliente = new ClienteCpfValidoSpecification();

            RuleSet("all", () =>
            {
                RuleFor(x => x.Cpf).Must(CPFCliente.IsSatisfiedBy).WithMessage("Cpf inválido");
                RuleFor(x => x.Nome).NotNull().WithMessage("Nome obrigatório");
                RuleFor(x => x.DataNascimento).NotNull().WithMessage("Nascimento obrigatório");
            });

        }
    }
}
