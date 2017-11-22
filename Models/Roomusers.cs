using System;
using System.Collections.Generic;

namespace KupcheAspNetCore
{
    public partial class Roomusers
    {
        public int IdRoomUsers { get; set; }
        public int UserId { get; set; }
        public int RoomId { get; set; }
        public sbyte? IsDeleted { get; set; }
        public DateTime AdditionTime { get; set; }
        public DateTime LastUpdate { get; set; }

        public Rooms Room { get; set; }
        public Users User { get; set; }
    }
}
