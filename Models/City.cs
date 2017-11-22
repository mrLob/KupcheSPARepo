using System;
using System.Collections.Generic;

namespace KupcheAspNetCore
{
    public partial class City
    {
        public City()
        {
            Addresses = new HashSet<Addresses>();
        }

        public int IdCity { get; set; }
        public string CityName { get; set; }
        public int CountryId { get; set; }
        public DateTime AdditionTime { get; set; }
        public DateTime LastUpdate { get; set; }

        public Country Country { get; set; }
        public ICollection<Addresses> Addresses { get; set; }
    }
}
