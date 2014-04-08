using Repository.Repository.Contracts;
using System;
using System.Collections.Generic;

namespace Repository.Repository
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        public GenericRepository(IDataContext context)
        {
            if (context == null)
                throw new ArgumentNullException("context", "Context null");

            this.Context = context;
        }

        protected IDataContext Context { get; private set; }

        public virtual IEnumerable<TEntity> GetAll()
        {
            throw new NotImplementedException("TODO");
        }

        public virtual TEntity GetByID(object id)
        {
            throw new NotImplementedException("TODO");
        }
    }
}