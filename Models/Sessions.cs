using System;
using System.Collections.Generic;

namespace KupcheAspNetCore
{
    public partial class Sessions
    {
        public int IdSessions { get; set; }
        public string SessionIp { get; set; }
        public int UserId { get; set; }
        public DateTime BeginTime { get; set; }

        public Users User { get; set; }
    }
}
