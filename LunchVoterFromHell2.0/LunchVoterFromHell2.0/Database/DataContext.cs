using LunchVoterFromHell2.Database.Mapping;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace LunchVoterFromHell2.Database
{
    public class DataContext : DbContext
    {
        public DbSet<Group> Groups { get; set; }
    }
}