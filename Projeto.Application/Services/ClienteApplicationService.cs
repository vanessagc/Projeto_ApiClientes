using Projeto.Application.Contracts;
using Projeto.Application.Models;
using Projeto.Domain.Contracts.Services;
using System;
using System.Collections.Generic;
using AutoMapper;
using Projeto.Domain.Entities;

namespace Projeto.Application.Services
{
    public class ClienteApplicationService : IClienteApplicationService
    {
        private readonly IClienteDomainService domainService;
        private readonly IMapper _mapper;

        public ClienteApplicationService()
        {
        }
        public void Create(ClienteModel model)
        {
            var cliente = _mapper.Map<Cliente>(model);
            domainService.Create(cliente);
        }

        public void Dispose()
        {
            domainService.Dispose();
        }

        public void Remove(Guid id)
        {
            domainService.Remove(id);
        }

        public List<ClienteModel> SelectAll()
        {
            var model = _mapper.Map<List<ClienteModel>>(domainService.SelectAll());
            return model;
        }

        public ClienteModel SelectById(Guid id)
        {
            var model = _mapper.Map<ClienteModel>(domainService.SelectById(id));
            return model;
        }

        public void Update(ClienteModel model)
        {
            var cliente = _mapper.Map<Cliente>(model);
            domainService.Update(cliente);
        }
    }
}
