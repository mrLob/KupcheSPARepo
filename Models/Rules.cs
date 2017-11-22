using System;
using System.Collections.Generic;

namespace KupcheAspNetCore
{
    public partial class Rules
    {
        public Rules()
        {
            Users = new HashSet<Users>();
        }

        public int IdRules { get; set; }
        public string Name { get; set; }
        public sbyte? IsDeleted { get; set; }
        public DateTime AdditionTime { get; set; }
        public DateTime LastUpdate { get; set; }

        public ICollection<Users> Users { get; set; }
    }
}
