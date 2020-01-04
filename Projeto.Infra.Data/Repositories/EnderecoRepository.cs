using Projeto.Infra.Data.Contracts;
using Projeto.Infra.Data.Entities;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projeto.Infra.Data.Repositories
{
    public class EnderecoRepository : IEnderecoRepository
    {
        private ConcurrentDictionary<Guid, Endereco> context;

        public EnderecoRepository(ConcurrentDictionary<Guid, Endereco> context)
        {
            this.context = context;
        }
        public Endereco Create(Endereco obj)
        {
            context[obj.IdEndereco] = obj;
            return obj;

        }

        public Endereco Remove(Guid id)
        {
            var endereco = new Endereco();
            context.Remove(id, out endereco);

            return endereco;
        }

        public IEnumerable<Endereco> SelectAll()
        {
            return context.Values
                    .OrderBy(p => p.Estado).ThenBy(p => p.Cidade).ThenBy(p => p.Bairro).ThenBy(p => p.Logradouro)
                    .ToList();
        }

        public Endereco SelectById(Guid id)
        {
            return context.Values
                    .SingleOrDefault(p => p.IdEndereco.Equals(id));
        }

        public Endereco Update(Endereco obj)
        {
            if(context[obj.IdEndereco] != null)
                context[obj.IdEndereco] = obj;

            return obj;
        }
    }
}
