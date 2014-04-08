using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Entities
{
    public class Vote
    {
        public int Id { get; set; }

        public Restaurant Restaurant { get; set; }

        public Person Person { get; set; }

        public DateTime Date { get; set; }
    }
}