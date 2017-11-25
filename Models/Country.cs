using System;
using System.Collections.Generic;

namespace KupcheAspNetCore
{
    public partial class Country
    {
        public Country()
        {
            City = new HashSet<City>();
        }

        public int IdCountry { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public DateTime AdditionTime { get; set; }
        public DateTime LastUpdate { get; set; }

        public ICollection<City> City { get; set; }
    }
}
