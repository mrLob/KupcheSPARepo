using System;
using System.Collections.Generic;

namespace KupcheAspNetCore
{
    public partial class Companies
    {
        public Companies()
        {
            Companyactivity = new HashSet<Companyactivity>();
            Pricelist = new HashSet<Pricelist>();
            Users = new HashSet<Users>();
        }

        public int IdCompany { get; set; }
        public string CompanyName { get; set; }
        public string CompanyShortName { get; set; }
        public string CompanyContacts { get; set; }
        public string CompaniesAbout { get; set; }
        public string CompanyPan { get; set; }
        public int AddressId { get; set; }
        public sbyte? IsDeleted { get; set; }
        public DateTime AdditionTime { get; set; }
        public DateTime LastUpdate { get; set; }

        public Addresses Address { get; set; }
        public ICollection<Companyactivity> Companyactivity { get; set; }
        public ICollection<Pricelist> Pricelist { get; set; }
        public ICollection<Users> Users { get; set; }
    }
}
