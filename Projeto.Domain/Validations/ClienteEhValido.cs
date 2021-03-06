﻿using FluentValidation;
using Projeto.Domain.Entities;
using Projeto.Domain.Specifications;

namespace Projeto.Domain.Validations
{
    public class ClienteEhValido : AbstractValidator<Cliente>
    {
        public ClienteEhValido()
        {

            var CPFCliente = new ClienteCpfValidoSpecification();
            var NomeCliente = new ClienteNomeValidoSpecification();

            RuleSet("all", () =>
            {
                RuleFor(x => x.Cpf).Must(CPFCliente.IsSatisfiedBy).WithMessage("Cpf inválido");
                RuleFor(x => x.Nome).NotNull().WithMessage("Nome obrigatório");
                RuleFor(x => x.Nome).Must(NomeCliente.IsSatisfiedBy).WithMessage("Nome obrigatório");
                RuleFor(x => x.DataNascimento).NotNull().WithMessage("Nascimento obrigatório");
            });

        }
    }
}
