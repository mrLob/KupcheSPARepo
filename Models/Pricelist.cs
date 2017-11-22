using System;
using System.Collections.Generic;

namespace KupcheAspNetCore
{
    public partial class Pricelist
    {
        public int IdPricelist { get; set; }
        public double PricelistCount { get; set; }
        public int GoodsId { get; set; }
        public int CompanyId { get; set; }
        public int CurrencyId { get; set; }
        public sbyte? IsDeleted { get; set; }
        public DateTime AdditionTime { get; set; }
        public DateTime LastUpdate { get; set; }

        public Companies Company { get; set; }
        public Currencies Currency { get; set; }
        public Goods Goods { get; set; }
    }
}
