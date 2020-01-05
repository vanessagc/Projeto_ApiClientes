using Projeto.Domain.Validations.EnderecoRules;
using Projeto.Domain.Validations.EnderecoRules;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Domain.Specifications
{
    public class EnderecoLogradouroValidoSpecification
    {
        public bool IsSatisfiedBy(string logradouro)
        {
            return LogradouroValidation.Validar(logradouro);
        }

    }
}
