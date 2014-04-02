﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LunchVoterFromHell2.Database.Mapping
{
    public class Person
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public Group Group { get; set; }
        public Boolean Owner { get; set; }
    }
}