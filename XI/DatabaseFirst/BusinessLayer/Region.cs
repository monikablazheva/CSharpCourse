using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessLayer
{
    public partial class Region
    {
        public Region()
        {
            Countries = new HashSet<Country>();
        }

        public short RegionId { get; set; }
        public string RegionName { get; set; }

        public virtual ICollection<Country> Countries { get; set; }
    }
}
