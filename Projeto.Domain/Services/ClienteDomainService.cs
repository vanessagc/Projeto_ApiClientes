using Projeto.Domain.Contracts.Repositories;
using Projeto.Domain.Contracts.Services;
using Projeto.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Domain.Services
{
    public class ClienteDomainService
        :BaseDomainService<Cliente>, IClienteDomainService
    {
        private readonly IClienteRepository repository;

        public ClienteDomainService(IClienteRepository repository)
            : base (repository)
        {
            this.repository = repository;
        }

        public Cliente SelectByCpf(string cpf)
        {
            return repository.SelectByCpf(cpf);
        }

        public Cliente SelectByNome(string nome)
        {
            return repository.SelectByNome(nome);
        }
    }
}
