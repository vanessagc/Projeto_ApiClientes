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
            cliente.Enderecos = _mapper.Map<IEnumerable<Endereco>>(model);

            if (!cliente.ValidationResult.IsValid)
            {
                var clienteRetorno = _domainService.Create(cliente);
                model = _mapper.Map<ClienteEnderecoModel>(clienteRetorno);

                foreach(Endereco endereco in cliente.Enderecos)
                {
                    var enderecoRetorno = _domainEnderecoService.Create(endereco);
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

        public void Remove(ClienteEnderecoModel model)
        {
            var cliente = _mapper.Map<Cliente>(model);
            cliente.Enderecos = _mapper.Map<IEnumerable<Endereco>>(model);

            cliente = _domainService.SelectById(cliente.IdCliente);

            foreach(Endereco endereco in cliente.Enderecos)
            {
                _domainEnderecoService.Remove(endereco);
            }

            _domainService.Remove(cliente);
        }

        public IEnumerable<ClienteEnderecoModel> SelectAll()
        {
            var model = _mapper.Map<IEnumerable<ClienteEnderecoModel>>(_domainService.SelectAll());
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

        public ClienteEnderecoModel SelectByNome(string nome)
        {
            var model = _mapper.Map<ClienteEnderecoModel>(_domainService.SelectByNome(nome));
            return model;
        }

        public ClienteEnderecoModel Update(ClienteEnderecoModel model)
        {
            var cliente = _mapper.Map<Cliente>(model);
            cliente.Enderecos = _mapper.Map<IEnumerable<Endereco>>(model);

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
