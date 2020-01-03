using FluentAssertions;
using Newtonsoft.Json;
using Projeto.Application.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Projeto.Presentation.Tests.Cenarios
{
    public class ClienteTest
    {
        private readonly TestContext testContext;
        private readonly string endpoint;

        public ClienteTest()
        {
            testContext = new TestContext();
            endpoint = "/api/cliente";
        }

        [Fact] 
        public async Task Cliente_Post_ReturnsOkResponse()
        {

            var model = new ClienteModel
            {
                Nome = "Cliente Teste",
                Cpf = "00842426710",
                Idade = 40,
                DataNascimento = DateTime.Parse("1974/03/13", new CultureInfo("pt-BR"))
        };

            var request = new StringContent(JsonConvert.SerializeObject(model),
                            Encoding.UTF8, "application/json");

            var response = await testContext.Client.PostAsync(endpoint, request);

            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }

        [Fact] 
        public async Task Cliente_Put_ReturnsOkResponse()
        {
            var model = new ClienteModel
            {
                IdCliente=Guid.NewGuid(),
                Nome = "Cliente Teste",
                Cpf = "00842426710",
                Idade = 40,
                DataNascimento = DateTime.Parse("1974/03/13", new CultureInfo("pt-BR"))
            };

            var request = new StringContent(JsonConvert.SerializeObject(model),
                            Encoding.UTF8, "application/json");

            var response = await testContext.Client.PutAsync(endpoint, request);

             response.StatusCode.Should().Be(HttpStatusCode.OK);
        }

        [Fact]
        public async Task Cliente_Delete_ReturnsOkResponse()
        {
            var idCliente = Guid.NewGuid();

            var response = await testContext.Client.DeleteAsync(endpoint + "/" + idCliente);

            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }

        [Fact]
        public async Task Cliente_GetAll_ReturnsOkResponse()
        {
            var response = await testContext.Client.GetAsync(endpoint);
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }

        [Fact]
        public async Task Cliente_GetById_ReturnsOkResponse()
        {
            var idCliente = Guid.NewGuid();

            var response = await testContext.Client.GetAsync(endpoint + "/" + idCliente);

            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }
    }
}
