using LunchVoterFromHell2.Database.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LunchVoterFromHell2.Models
{
    public class Ranking
    {
        public Restaurant restaurant { get; set; }
        public int votesCount { get; set; }
    }
}