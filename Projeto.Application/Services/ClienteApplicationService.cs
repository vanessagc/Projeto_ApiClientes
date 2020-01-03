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
        private readonly IEnderecoDomainService _domainEnderecoService;
        private readonly IMapper _mapper;

        public ClienteApplicationService(IClienteDomainService domainService, IEnderecoDomainService domainEnderecoService, IMapper mapper)
        {
            this._domainService = domainService;
            this._domainEnderecoService = domainEnderecoService;
            this._mapper = mapper;

        }
        public ClienteEnderecoModel Create(ClienteEnderecoModel model)
        {
            var cliente = _mapper.Map<Cliente>(model);
            cliente.Enderecos = _mapper.Map<ICollection<Endereco>>(model);
            Cliente clienteRetorno;
            Endereco enderecoRetorno;

            if (!cliente.ValidationResult.IsValid)
            {
                clienteRetorno = _domainService.Create(cliente);
                model = _mapper.Map<ClienteEnderecoModel>(clienteRetorno);

                foreach(Endereco endereco in cliente.Enderecos)
                {
                    enderecoRetorno = _domainEnderecoService.Create(endereco);
                    model = _mapper.Map<ClienteEnderecoModel>(enderecoRetorno);
                }

            } else
            {
                cliente.ValidationResult.Message = "CPF inválido!";
                model = _mapper.Map<ClienteEnderecoModel>(cliente);
            }

            return model;

        }

        public void Dispose()
        {
            _domainService.Dispose();
        }

        public void Remove(Guid id)
        {

            var cliente = _domainService.SelectById(id);

            foreach(Endereco endereco in cliente.Enderecos)
            {
                _domainEnderecoService.Remove(endereco.IdEndereco);
            }

            _domainService.Remove(id);
        }

        public IEnumerable<ClienteEnderecoModel> SelectAll()
        {
            var model = _mapper.Map<List<ClienteEnderecoModel>>(_domainService.SelectAll());
            return model;
        }

        public ClienteEnderecoModel SelectByCpf(string Cpf)
        {
            var model = _mapper.Map<ClienteEnderecoModel>(_domainService.SelectByCpf(Cpf));
            return model;
        }

        public ClienteEnderecoModel SelectById(Guid id)
        {
            var model = _mapper.Map<ClienteEnderecoModel>(_domainService.SelectById(id));
            return model;
        }

        public ClienteEnderecoModel Update(ClienteEnderecoModel model)
        {
            var cliente = _mapper.Map<Cliente>(model);
            cliente.Enderecos = _mapper.Map<ICollection<Endereco>>(model);

            var clienteRetorno = _domainService.Update(cliente);
            model = _mapper.Map<ClienteEnderecoModel>(clienteRetorno);

            foreach (Endereco endereco in cliente.Enderecos)
            {
                var enderecoRetorno = _domainEnderecoService.Update(endereco);
                model = _mapper.Map<ClienteEnderecoModel>(enderecoRetorno);
            }

            return model;
        }
    }
}
