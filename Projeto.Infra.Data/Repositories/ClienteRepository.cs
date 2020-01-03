using Projeto.Infra.Data.Contracts;
using Projeto.Infra.Data.Entities;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projeto.Infra.Data.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private ConcurrentDictionary<Guid, Cliente> context;

        public ClienteRepository(ConcurrentDictionary<Guid, Cliente> context)
        {
            this.context = context;
        }
        public Cliente Create(Cliente obj)
        {
            context[obj.IdCliente] = obj;

            return obj;
        }

        public Cliente Remove(Guid id)
        {
            var cliente = new Cliente();
            context.Remove(id, out cliente);

            return cliente;
        }

        public List<Cliente> SelectAll()
        {
            return context.Values
                    .OrderBy(p => p.Nome)
                    .ToList();
        }

        public Cliente SelectById(Guid id)
        {
            return context.Values
                    .SingleOrDefault(p => p.IdCliente.Equals(id));
        }

        public Cliente Update(Cliente obj)
        {
            if(context[obj.IdCliente] != null)
                context[obj.IdCliente] = obj;

            return obj;
        }
    }
}
