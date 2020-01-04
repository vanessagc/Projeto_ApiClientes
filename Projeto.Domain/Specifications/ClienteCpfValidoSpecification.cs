using Projeto.Domain.Entities;
using Projeto.Domain.Validations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Domain.Specifications
{
    public class ClienteCpfValidoSpecification 
    {
        public bool IsSatisfiedBy(Cliente cliente)
        {
            return CPFValidation.Validar(cliente.Cpf);
        }
    }
}
