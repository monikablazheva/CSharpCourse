﻿using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessLayer
{
    public partial class Country
    {
        public Country()
        {
            Cities = new HashSet<City>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Population { get; set; }

        public virtual ICollection<City> Cities { get; set; }
    }
}
