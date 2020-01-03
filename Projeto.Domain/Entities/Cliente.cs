using DomainValidation.Validation;
using Projeto.Domain.Validations;
using System;

namespace Projeto.Domain.Entities
{
    public class Cliente
    {
        public Guid IdCliente { get; set; }
      
        public string Nome { get; set; }
        
        public string Cpf { get; set; }
        
        public int Idade { get; set; }
        
        public DateTime DataNascimento { get; set; }

        public ValidationResult ValidationResult { get; set; }
        public bool IsValid()
        {
            ValidationResult = new ClienteEhValido().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
