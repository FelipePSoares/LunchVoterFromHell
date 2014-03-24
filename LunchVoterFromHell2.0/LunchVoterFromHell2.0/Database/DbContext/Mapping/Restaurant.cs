using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LunchVoterFromHell2._0.Database.DbContext.Mapping
{
    public class Restaurant
    {
        public int Id { get; set; }
        public String Nome { get; set; }
        public List<Week> Week { get; set; }
        public Decimal Price { get; set; }
    }
}