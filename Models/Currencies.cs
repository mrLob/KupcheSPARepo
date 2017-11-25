﻿using System;
using System.Collections.Generic;

namespace KupcheAspNetCore
{
    public partial class Currencies
    {
        public Currencies()
        {
            Pricelist = new HashSet<Pricelist>();
        }

        public int IdCurrencies { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public DateTime AdditionTime { get; set; }
        public DateTime LastUpdate { get; set; }

        public ICollection<Pricelist> Pricelist { get; set; }
    }
}