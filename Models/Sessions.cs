using System;
using System.Collections.Generic;

namespace KupcheAspNetCore
{
    public partial class Sessions
    {
        public int IdSessions { get; set; }
        public string Ip { get; set; }
        public int UserId { get; set; }
        public DateTime BeginTime { get; set; }

        public Users User { get; set; }
    }
}
