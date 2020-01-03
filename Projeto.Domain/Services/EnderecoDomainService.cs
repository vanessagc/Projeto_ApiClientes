using Projeto.Domain.Contracts.Repositories;
using Projeto.Domain.Contracts.Services;
using Projeto.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Domain.Services
{    
    public class EnderecoDomainService
        : BaseDomainService<Endereco>, IEnderecoDomainService
    {
        private readonly IEnderecoRepository repository;

        public EnderecoDomainService(IEnderecoRepository repository)
            : base(repository)
        {
            this.repository = repository;
        }
    }
}
