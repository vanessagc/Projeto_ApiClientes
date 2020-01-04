using Projeto.Domain.Entities;
using Projeto.Domain.Specifications;
using System;
using Xunit;

namespace Projeto.Domain.Tests
{
    public class ClienteTest
    {
        [Fact]
        public void ClienteTest_VerificaCPF_Invalido()
        {
            //Arrange
            var CPFCliente = new ClienteCpfValidoSpecification();
            Cliente cliente = new Cliente()
            {
                Cpf="11111",
                Nome = "Vanessa 123",
                Idade = 43,
                DataNascimento = new DateTime(1980,01,31)
            };

            // Act
            var result = CPFCliente.IsSatisfiedBy(cliente.Cpf);

            //Assert
            Assert.False(result);
        }

        [Fact]
        public void ClienteTest_VerificaCPF_Valido()
        {
            //Arrange
            var CPFCliente = new ClienteCpfValidoSpecification();
            Cliente cliente = new Cliente()
            {
                Cpf = "00842426710",
                Nome = "Vanessa 123",
                Idade = 43,
                DataNascimento = new DateTime(1980, 01, 31)
            };

            // Act
            var result = CPFCliente.IsSatisfiedBy(cliente.Cpf);

            //Assert
            Assert.True(result);
        }
    }
}
