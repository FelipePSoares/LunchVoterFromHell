using Entities;
using System;
using System.Data.Entity;
using System.Linq;

namespace Repository
{
    public interface IDataContext : IDisposable
    {
        IQueryable<Group> Groups { get; }

        IQueryable<Person> Persons { get; }

        IQueryable<Restaurant> Restaurants { get; }

        IQueryable<Vote> Votes { get; }

        IQueryable<Week> Weeks { get; }

        DbSet DbSet<T>() where T : class;
    }
}