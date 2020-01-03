using Projeto.Domain.Contracts.Repositories;
using Projeto.Domain.Contracts.Services;
using System;
using System.Collections.Generic;

namespace Projeto.Domain.Services
{
    public abstract class BaseDomainService<TEntity>
        : IBaseDomainService<TEntity>
        where TEntity : class
    {
        private readonly IBaseRepository<TEntity> repository;

        protected BaseDomainService(IBaseRepository<TEntity> repository)
        {
            this.repository = repository;
        }
        public virtual TEntity Create(TEntity obj)
        {
            return repository.Create(obj);
        }

        public virtual void Dispose()
        {
            repository.Dispose();
        }

        public virtual TEntity Remove(Guid id)
        {
            return repository.Remove(id);
        }

        public virtual List<TEntity> SelectAll()
        {
            return repository.SelectAll();
        }

        public TEntity SelectByCpf(string Cpf)
        {
            throw new NotImplementedException();
        }

        public virtual TEntity SelectById(Guid id)
        {
            return repository.SelectById(id);
        }

        public virtual TEntity Update(TEntity obj)
        {
            return repository.Update(obj);
        }

    }
}
