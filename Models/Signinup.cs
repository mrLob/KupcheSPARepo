using System;
using System.Collections.Generic;

namespace KupcheAspNetCore
{
    public partial class Signinup
    {
        public int IdSignInUp { get; set; }
        public string Mail { get; set; }
        public string Token { get; set; }
        public DateTime? ActivatedIn { get; set; }
        public sbyte? IsActivated { get; set; }
        public DateTime ExpiredIn { get; set; }
    }
}
