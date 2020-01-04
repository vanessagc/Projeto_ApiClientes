using AutoMapper;
using Projeto.Application.Contracts;
using Projeto.Application.Models;
using Projeto.Domain.Contracts.Services;
using Projeto.Domain.Entities;
using System;
using System.Collections.Generic;

namespace Projeto.Application.Services
{
    public class ClienteApplicationService : IClienteApplicationService
    {
        private readonly IClienteDomainService _domainService;
        private readonly IMapper _mapper;

        public ClienteApplicationService(IClienteDomainService domainService, IMapper mapper)
        {
            this._domainService = domainService;
            this._mapper = mapper;

        }
        public ClienteModel Create(ClienteModel model)
        {
            var cliente = _mapper.Map<Cliente>(model);

            //if (!cliente.ValidationResult.IsValid)
            //{
                var clienteRetorno = _domainService.Create(cliente);
                model = _mapper.Map<ClienteModel>(clienteRetorno);

            //} 
            //else
            //{
            //    cliente.ValidationResult.Message = "CPF inválido!";
            //    model = _mapper.Map<ClienteModel>(cliente);
            //}

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

            var clienteRetorno = _domainService.Update(cliente);
            model = _mapper.Map<ClienteModel>(clienteRetorno);

            return model;
        }
    }
}
