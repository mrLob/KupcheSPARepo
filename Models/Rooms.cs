using System;
using System.Collections.Generic;

namespace KupcheAspNetCore
{
    public partial class Rooms
    {
        public Rooms()
        {
            Messages = new HashSet<Messages>();
            Roomusers = new HashSet<Roomusers>();
        }

        public int IdRooms { get; set; }
        public string Name { get; set; }
        public int CreatorId { get; set; }
        public sbyte? IsDeleted { get; set; }
        public sbyte? IsCompanyRoom { get; set; }
        public DateTime AdditionTime { get; set; }
        public DateTime LastUpdate { get; set; }

        public Users RoomsCreator { get; set; }
        public ICollection<Messages> Messages { get; set; }
        public ICollection<Roomusers> Roomusers { get; set; }
    }
}
