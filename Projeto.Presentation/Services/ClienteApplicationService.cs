using Projeto.Domain.Contracts.Services;
using Projeto.Presentation.Api.Contracts;
using Projeto.Presentation.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.Presentation.Api.Services
{
    public class ClienteApplicationService : IClienteApplicationService
    {
        private readonly IClienteDomainService domainService;

        public ClienteApplicationService(IClienteDomainService domainService)
        {
            this.domainService = domainService;
        }
        public void Create(ClienteCadastroModel model)
        {
            //domainService.Create(model);
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

        public List<ClienteConsultaModel> SelectAll()
        {
            throw new NotImplementedException();
        }

        public ClienteConsultaModel SelectById(string id)
        {
            throw new NotImplementedException();
        }

        public void Update(ClienteEdicaoModel model)
        {
            throw new NotImplementedException();
        }
    }
}
