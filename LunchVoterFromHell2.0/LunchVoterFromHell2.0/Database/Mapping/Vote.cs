using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LunchVoterFromHell2.Database.Mapping
{
    public class Vote
    {
        public int Id { get; set; }
        [Required]
        public Restaurant Restaurant { get; set; }

        public Person Person { get; set; }

        public DateTime Date { get; set; }
    }
}