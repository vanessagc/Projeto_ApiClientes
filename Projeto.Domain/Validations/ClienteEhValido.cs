using Projeto.Domain.Entities;
using Projeto.Domain.Specifications;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Domain.Validations
{
    public class ClienteEhValido 
    {
        public ClienteEhValido()
        {
            var CPFCliente = new ClienteCpfValidoSpecification();

            //base.Add("CPFCliente", new Rule<Cliente>(CPFCliente, "Cliente com CPF inválido."));
        }
    }
}
