using Microsoft.EntityFrameworkCore;
using Projeto.Domain.Contracts.Repositories;
using Projeto.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;

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

        public virtual TEntity Create(TEntity obj)
        {
            dataContext.Entry(obj).State = EntityState.Added;
            dataContext.SaveChanges();
            return obj;
        }

        public virtual TEntity Update(TEntity obj)
        {
            dataContext.Entry(obj).State = EntityState.Modified;
            dataContext.SaveChanges();
            return obj;
        }

        public virtual void Remove(TEntity obj)
        {
            dataContext.Entry(obj).State = EntityState.Deleted;
            dataContext.SaveChanges();
        }

        public virtual IEnumerable<TEntity> SelectAll()
        {
            return dataContext.Set<TEntity>();
        }

        public virtual TEntity SelectById(Guid id)
        {
            return dataContext.Set<TEntity>().Find(id);
        }


        public virtual IEnumerable<TEntity> SelectAll(Func<TEntity, bool> where)
        {
            return dataContext.Set<TEntity>().Where(where);
        }

        public virtual void Dispose()
        {
            dataContext.Dispose();
        }

    }
}
