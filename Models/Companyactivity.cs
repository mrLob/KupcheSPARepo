using System;
using System.Collections.Generic;

namespace KupcheAspNetCore
{
    public partial class Companyactivity
    {
        public int IdCompanyActivity { get; set; }
        public int CompanyId { get; set; }
        public int ActivityTypeId { get; set; }
        public DateTime AdditionTime { get; set; }
        public DateTime LastUpdate { get; set; }

        public Activitytypes ActivityType { get; set; }
        public Companies Company { get; set; }
    }
}
