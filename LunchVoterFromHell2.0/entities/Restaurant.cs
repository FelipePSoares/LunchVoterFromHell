﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Entities
{
    public class Restaurant
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<Week> Days { get; set; }

        public decimal Price { get; set; }
    }
}