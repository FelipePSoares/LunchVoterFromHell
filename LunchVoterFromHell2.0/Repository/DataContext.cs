using Entities;
using System;
using System.Data.Entity;
using System.Linq;

namespace Repository
{
    public class DataContext : DbContext, IDisposable, IDataContext
    {
        #region Tables

        IQueryable<Group> IDataContext.Groups
        {
            get { return this.Set<Group>(); }
        }

        IQueryable<Person> IDataContext.Persons
        {
            get { return this.Set<Person>(); }
        }

        IQueryable<Restaurant> IDataContext.Restaurants
        {
            get { return this.Set<Restaurant>(); }
        }

        IQueryable<Vote> IDataContext.Votes
        {
            get { return this.Set<Vote>(); }
        }

        IQueryable<Week> IDataContext.Weeks
        {
            get { return this.Set<Week>(); }
        }

        #endregion

        public void Add<T>(T model) where T : class
        {
            this.Set<T>().Add(model);
        }

        public void Update<T>(T model) where T : class
        {
            this.Set<T>().Attach(model);
            this.Entry<T>(model).State = EntityState.Modified;
        }

        public void Delete<T>(Object id) where T : class
        {
            var entityToDelete = this.Set<T>().Find(id);
            Delete(entityToDelete);
        }

        public void Delete<T>(T entityToDelete) where T : class
        {
            if (this.Entry<T>(entityToDelete).State == EntityState.Detached)
            {
                this.Set<T>().Attach(entityToDelete);
            }
            this.Set<T>().Remove(entityToDelete);
        }
    }
}