using System;
using System.Collections.Generic;

namespace Country_Info
{
    public partial class Countries
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Code { get; set; }
        public int Capital { get; set; }
        public double Area { get; set; }
        public int Region { get; set; }

        public virtual Cities CapitalNavigation { get; set; }
        public virtual Regions RegionNavigation { get; set; }
    }
}
