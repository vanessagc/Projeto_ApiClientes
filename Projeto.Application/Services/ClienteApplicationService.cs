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
        public ClienteEnderecoModel Create(ClienteEnderecoModel model)
        {
            var cliente = _mapper.Map<Cliente>(model);
            var endereco = _mapper.Map<Endereco>(model);
            Cliente clienteRetorno;

            cliente.Enderecos.Add(endereco);

            if (!cliente.ValidationResult.IsValid)
            {
                clienteRetorno = domainService.Create(cliente);
                model = _mapper.Map<ClienteEnderecoModel>(clienteRetorno);
            } else
            {
                cliente.ValidationResult.Message = "CPF inválido!";
                model = _mapper.Map<ClienteEnderecoModel>(cliente);
            }

            return model;

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

        public ClienteModel SelectByCpf(string Cpf)
        {
            var model = _mapper.Map<ClienteModel>(domainService.SelectByCpf(Cpf));
            return model;
        }

        public ClienteModel SelectById(Guid id)
        {
            var model = _mapper.Map<ClienteModel>(domainService.SelectById(id));
            return model;
        }

        public ClienteModel Update(ClienteModel model)
        {
            var cliente = _mapper.Map<Cliente>(model);
            domainService.Update(cliente);
            model = _mapper.Map<ClienteModel>(cliente);

            return model;
        }
    }
}
