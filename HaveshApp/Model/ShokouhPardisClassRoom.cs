using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class ShokouhPardisClassRoom
    {
        public int ClassRoomId { get; set; }
        public Guid ClassRoomGuid { get; set; }
        public DateTime ClassRoomLastModified { get; set; }
        public string ClassRoomName { get; set; } = null!;
        public int? Capacity { get; set; }
        public int? MinCapacity { get; set; }
        public int? MaxCapacity { get; set; }
        public string? Describtion { get; set; }
    }
}
