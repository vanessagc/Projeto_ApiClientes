using Microsoft.EntityFrameworkCore;
using Projeto.Domain.Contracts.Repositories;
using Projeto.Domain.Entities;
using Projeto.Infra.Data.Context;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projeto.Infra.Data.Repositories
{
    public class ClienteRepository : BaseRepository<Cliente>, IClienteRepository
    {

        private readonly DataContext dataContext;
        public ClienteRepository(DataContext dataContext)
        : base(dataContext)
        {
            this.dataContext = dataContext;
        }

        public override IEnumerable<Cliente> SelectAll()
        {
            return dataContext.Cliente.Include(f => f.Enderecos).ToList();
        }
        public override IEnumerable<Cliente> SelectAll(Func<Cliente, bool> where)
        {
            return dataContext.Cliente.Include

            (f => f.Enderecos).Where(where);

        }

        public Cliente SelectByCpf(string cpf)
        {
            return dataContext.Cliente.Include(f => f.Enderecos)
            .SingleOrDefault(f => f.Cpf.Equals(cpf));
        }

        public Cliente SelectByNome(string nome)
        {
            return dataContext.Cliente.Include(f => f.Enderecos)
            .SingleOrDefault(f => f.Nome.Equals(nome));
        }



    }
}
