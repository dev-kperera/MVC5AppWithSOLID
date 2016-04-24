using System;
using System.Linq;

namespace Contracts
{
    public interface IRepositoryBase<TEntity>
     where TEntity : class
    {
        void Delete(TEntity entity);
        void Dispose();
        IQueryable<TEntity> GetAll();
        TEntity GetByID(object id);
        void Insert(TEntity entity);
        void Save();
        void Update(TEntity entity);
    }
}
