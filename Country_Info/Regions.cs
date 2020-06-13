using System;
using System.Collections.Generic;

namespace Country_Info
{
    public partial class Regions
    {
        public Regions()
        {
            Countries = new HashSet<Countries>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Countries> Countries { get; set; }
    }
}
