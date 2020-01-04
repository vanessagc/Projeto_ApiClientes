using Microsoft.EntityFrameworkCore;
using Projeto.Domain.Contracts.Repositories;
using Projeto.Infra.Data.Context;
using System;
using System.Collections.Generic;

namespace Projeto.Infra.Data.Repositories
{
    public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity>
        where TEntity:class
    {
        private readonly DataContext dataContext;
        protected BaseRepository(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public TEntity Create(TEntity obj)
        {
            dataContext.Entry(obj).State = EntityState.Added;
            dataContext.SaveChanges();
            return obj;
        }

        public void Dispose()
        {
            dataContext.Dispose();
        }

        public void Remove(TEntity obj)
        {
            dataContext.Entry(obj).State = EntityState.Deleted;
            dataContext.SaveChanges();
        }

        public IEnumerable<TEntity> SelectAll()
        {
            throw new NotImplementedException();
        }

        public TEntity SelectById(Guid id)
        {
            throw new NotImplementedException();
        }

        public TEntity Update(TEntity obj)
        {
            dataContext.Entry(obj).State = EntityState.Modified;
            dataContext.SaveChanges();
            return obj;
        }
    }
}
