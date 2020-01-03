using Projeto.Domain.Contracts.Services;
using Projeto.Presentation.Api.Contracts;
using Projeto.Presentation.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.Presentation.Api.Services
{
    public class EnderecoApplicationService : IEnderecoApplicationService
    {
        private readonly IEnderecoDomainService domainService;

        public void Create(EnderecoCadastroModel model)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Remove(string id)
        {
            throw new NotImplementedException();
        }

        public List<EnderecoConsultaModel> SelectAll()
        {
            throw new NotImplementedException();
        }

        public EnderecoConsultaModel SelectById(string id)
        {
            throw new NotImplementedException();
        }

        public void Update(EnderecoEdicaoModel model)
        {
            throw new NotImplementedException();
        }
    }
}
