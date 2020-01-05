using Projeto.Domain.Validations.ClienteRules;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Domain.Specifications
{
    public class ClienteNomeValidoSpecification
    {
        public bool IsSatisfiedBy(string nome)
        {
            return NomeValidation.Validar(nome);
        }

    }
}
