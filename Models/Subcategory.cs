﻿using System;
using System.Collections.Generic;

namespace KupcheAspNetCore
{
    public partial class Subcategory
    {
        public Subcategory()
        {
            Goods = new HashSet<Goods>();
            InverseOfChildNavigation = new HashSet<Subcategory>();
        }

        public int IdSubcategory { get; set; }
        public string Name { get; set; }
        public string Info { get; set; }
        public int CategoryId { get; set; }
        public sbyte? IsCategory { get; set; }
        public int? OfChild { get; set; }
        public DateTime AdditionTime { get; set; }
        public DateTime LastUpdate { get; set; }

        public Supercategories Category { get; set; }
        public Subcategory OfChildNavigation { get; set; }
        public ICollection<Goods> Goods { get; set; }
        public ICollection<Subcategory> InverseOfChildNavigation { get; set; }
    }
}
