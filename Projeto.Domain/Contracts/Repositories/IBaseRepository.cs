using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Domain.Contracts.Repositories
{
    public interface IBaseRepository<TEntity>
        where TEntity : class
    {
        TEntity Create(TEntity obj);
        TEntity Update(TEntity obj);
        TEntity Remove(Guid id);

        IEnumerable<TEntity> SelectAll();
        TEntity SelectById(Guid id);
        void Dispose();
    }
}
