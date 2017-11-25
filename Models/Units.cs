﻿using System;
using System.Collections.Generic;

namespace KupcheAspNetCore
{
    public partial class Units
    {
        public Units()
        {
            Goods = new HashSet<Goods>();
        }

        public int IdUnit { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public sbyte? IsDeleted { get; set; }
        public DateTime AdditionTime { get; set; }
        public DateTime LastUpdate { get; set; }

        public ICollection<Goods> Goods { get; set; }
    }
}