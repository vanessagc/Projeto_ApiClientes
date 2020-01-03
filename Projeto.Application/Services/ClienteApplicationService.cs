﻿using Projeto.Application.Contracts;
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

        public ClienteApplicationService()
        {
        }
        public void Create(ClienteModel model)
        {
            var cliente = Mapper.Map<Cliente>(model);
            //domainService.Create(cliente);
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
            //var model = Mapper.Map<ClienteConsultaModel>(domainService.SelectAll());
            //return model;
            return null;
        }

        public ClienteModel SelectById(Guid id)
        {
            //var model = Mapper.Map<ClienteConsultaModel>(domainService.SelectById(Guid.Parse(id)));
            //return model;
            return null;
        }

        public void Update(ClienteModel model)
        {
            //domainService.Update(Mapper.Map<Cliente>(model));
        }
    }
}
