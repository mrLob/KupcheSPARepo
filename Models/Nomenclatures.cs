using System;
using System.Collections.Generic;

namespace KupcheAspNetCore
{
    public partial class Nomenclatures
    {
        public Nomenclatures()
        {
            Goods = new HashSet<Goods>();
        }

        public int IdNomenclatures { get; set; }
        public string NomenclaturesName { get; set; }
        public sbyte? IsDeleted { get; set; }
        public DateTime AdditionTime { get; set; }
        public DateTime LastUpdate { get; set; }

        public ICollection<Goods> Goods { get; set; }
    }
}
