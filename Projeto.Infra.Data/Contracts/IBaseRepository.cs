using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Infra.Data.Contracts
{
    public interface IBaseRepository<TEntity>
        where TEntity : class
    {
        TEntity Create(TEntity obj);
        TEntity Update(TEntity obj);
        TEntity Remove(Guid id);

        List<TEntity> SelectAll();
        TEntity SelectById(Guid id);
    }
}
