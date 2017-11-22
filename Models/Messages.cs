using System;
using System.Collections.Generic;

namespace KupcheAspNetCore
{
    public partial class Messages
    {
        public int MsgId { get; set; }
        public string MessageText { get; set; }
        public int UsersId { get; set; }
        public int RoomId { get; set; }
        public sbyte? IsDeleted { get; set; }
        public sbyte? IsViewed { get; set; }
        public DateTime AdditionTime { get; set; }
        public DateTime LastUpdate { get; set; }

        public Rooms Room { get; set; }
        public Users Users { get; set; }
    }
}
