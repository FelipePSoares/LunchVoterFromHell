using System.Collections.Generic;

namespace Repository.Repository.Contracts
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetAll();

        TEntity GetByID(object id);
    }
}