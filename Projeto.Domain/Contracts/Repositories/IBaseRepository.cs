using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Domain.Contracts.Repositories
{
    public interface IBaseRepository<TEntity> : IDisposable
        where TEntity : class
    {
        TEntity Create(TEntity obj);
        TEntity Update(TEntity obj);
        void Remove(TEntity obj);

        IEnumerable<TEntity> SelectAll();
        TEntity SelectById(Guid id);
    }
}
