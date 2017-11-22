using System;
using System.Collections.Generic;

namespace KupcheAspNetCore
{
    public partial class Supercategories
    {
        public Supercategories()
        {
            Activitytypes = new HashSet<Activitytypes>();
            Subcategory = new HashSet<Subcategory>();
        }

        public int IdSuperCategories { get; set; }
        public string SuperCategoriesName { get; set; }
        public DateTime AdditionTime { get; set; }
        public DateTime LastUpdate { get; set; }

        public ICollection<Activitytypes> Activitytypes { get; set; }
        public ICollection<Subcategory> Subcategory { get; set; }
    }
}
