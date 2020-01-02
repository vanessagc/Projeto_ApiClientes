using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Infra.Data.Contracts
{
    public interface IBaseRepository<TEntity>
        where TEntity : class
    {
        void Create(TEntity obj);
        void Update(TEntity obj);
        TEntity Remove(Guid id);

        List<TEntity> SelectAll();
        TEntity SelectById(Guid id);
    }
}
