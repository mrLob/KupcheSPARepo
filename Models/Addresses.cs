using System;
using System.Collections.Generic;

namespace KupcheAspNetCore
{
    public partial class Addresses
    {
        public Addresses()
        {
            Companies = new HashSet<Companies>();
        }

        public int IdAddress { get; set; }
        public string AddressStreet { get; set; }
        public int? AddressNumber { get; set; }
        public string AddressFlat { get; set; }
        public string AddressZip { get; set; }
        public string AddressesGeomap { get; set; }
        public int CityId { get; set; }
        public sbyte? IsDeleted { get; set; }
        public DateTime AdditionTime { get; set; }
        public DateTime LastUpdate { get; set; }

        public City City { get; set; }
        public ICollection<Companies> Companies { get; set; }
    }
}
