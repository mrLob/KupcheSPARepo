using System;
using System.Collections.Generic;

namespace KupcheAspNetCore
{
    public partial class Positions
    {
        public Positions()
        {
            Users = new HashSet<Users>();
        }

        public int IdPositions { get; set; }
        public string PositionsName { get; set; }
        public string ShortName { get; set; }
        public DateTime AdditionTime { get; set; }
        public DateTime LastUpdate { get; set; }

        public ICollection<Users> Users { get; set; }
    }
}
