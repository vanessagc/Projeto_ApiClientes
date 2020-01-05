using Projeto.Domain.Validations.ClienteRules;

namespace Projeto.Domain.Specifications
{
    public class ClienteCpfValidoSpecification 
    {
        public bool IsSatisfiedBy(string cpf)
        {
            return CPFValidation.Validar(cpf);
        }
    }
}
