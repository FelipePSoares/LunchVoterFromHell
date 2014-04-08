using Entities;
using System;
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

        void Add<T>(T model) where T : class;

        void Update<T>(T model) where T : class;

        void Delete<T>(object id) where T : class;

        void Delete<T>(T model) where T : class;
    }
}