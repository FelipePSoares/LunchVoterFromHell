﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LunchVoterFromHell2.Database.Mapping
{
    public class Week
    {
        public int id { get; set; }
        public DayOfWeek Day { get; set; }
    }
}