using LunchVoterFromHell2.Database.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LunchVoterFromHell2.Models
{
    public class Index
    {
        public List<Ranking> Ranking { get; set; }
        public List<Restaurant> restaurants { get; set; }
        public int idRestaurant { get; set; }
    }
}