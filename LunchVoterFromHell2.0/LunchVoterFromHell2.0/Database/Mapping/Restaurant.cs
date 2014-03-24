using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LunchVoterFromHell2.Database.Mapping
{
    public class Restaurant
    {
        public int Id { get; set; }
        public String Nome { get; set; }
        public List<Week> Day { get; set; }
        public Decimal Price { get; set; }
    }
}