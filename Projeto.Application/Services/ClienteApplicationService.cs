using AutoMapper;
using FluentValidation;
using Projeto.Application.Contracts;
using Projeto.Application.Models;
using Projeto.Domain.Contracts.Services;
using Projeto.Domain.Entities;
using Projeto.Domain.Validations;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Projeto.Application.Services
{
    public class ClienteApplicationService : IClienteApplicationService
    {
        private readonly IClienteDomainService _domainService;
        private readonly IMapper _mapper;
        private readonly ClienteEhValido _validator;

        public ClienteApplicationService(IClienteDomainService domainService, IMapper mapper, ClienteEhValido validator)
        {
            this._domainService = domainService;
            this._mapper = mapper;
            this._validator = validator;

        }
        public ClienteModel Create(ClienteModel model)
        {
            var cliente = _mapper.Map<Cliente>(model);

            var result = _validator.Validate(cliente, ruleSet: "all");

            if (result.IsValid)
            {
                var clienteRetorno = _domainService.Create(cliente);
                model = _mapper.Map<ClienteModel>(clienteRetorno);
            }

            return model;

        }

        public void Dispose()
        {
            _domainService.Dispose();
        }

        public void Remove(ClienteModel model)
        {
            var cliente = _mapper.Map<Cliente>(model);

            cliente = _domainService.SelectById(cliente.IdCliente);

            _domainService.Remove(cliente);
        }

        public IEnumerable<ClienteModel> SelectAll()
        {
            var model = _mapper.Map<IEnumerable<ClienteModel>>(_domainService.SelectAll());
            return model;
        }

        public ClienteModel SelectByCpf(string Cpf)
        {
            var model = _mapper.Map<ClienteModel>(_domainService.SelectByCpf(Cpf));
            return model;
        }

        public ClienteModel SelectById(Guid id)
        {
            var model = _mapper.Map<ClienteModel>(_domainService.SelectById(id));
            return model;
        }

        public ClienteModel SelectByNome(string nome)
        {
            var model = _mapper.Map<ClienteModel>(_domainService.SelectByNome(nome));
            return model;
        }

        public ClienteModel Update(ClienteModel model)
        {
            var cliente = _mapper.Map<Cliente>(model);

            var result = _validator.Validate(cliente, ruleSet: "all");

            if (result.IsValid)
            {
                var clienteRetorno = _domainService.Update(cliente);
                model = _mapper.Map<ClienteModel>(clienteRetorno);
            }

            return model;
        }
    }
}
