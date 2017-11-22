using System;
using System.Collections.Generic;

namespace KupcheAspNetCore
{
    public partial class Activitytypes
    {
        public Activitytypes()
        {
            Companyactivity = new HashSet<Companyactivity>();
            InverseChildOfNavigation = new HashSet<Activitytypes>();
        }

        public int IdActivityTypes { get; set; }
        public string ActivityTypesName { get; set; }
        public int? ChildOf { get; set; }
        public int? CategoryId { get; set; }
        public sbyte? IsDeleted { get; set; }
        public DateTime AdditionTime { get; set; }
        public DateTime LastUpdate { get; set; }

        public Supercategories Category { get; set; }
        public Activitytypes ChildOfNavigation { get; set; }
        public ICollection<Companyactivity> Companyactivity { get; set; }
        public ICollection<Activitytypes> InverseChildOfNavigation { get; set; }
    }
}
