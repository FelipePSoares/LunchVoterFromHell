using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Entities
{
    public class Week
    {
        public int Id { get; set; }

        public DayOfWeek Day { get; set; }

        public Restaurant Restaurant { get; set; }
    }
}