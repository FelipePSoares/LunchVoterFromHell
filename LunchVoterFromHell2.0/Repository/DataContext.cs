using Entities;
using System;
using System.Data.Entity;
using System.Linq;

namespace Repository
{
    public class DataContext : DbContext, IDisposable, IDataContext
    {
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

        public DbSet DbSet<T>() where T : class
        {
            return Set<T>();
        }
    }
}