using Rafotel.Domain.ValueObject;
using System;
using System.Collections.Generic;
using System.Text;
using Rafotel.Domain.Base;

namespace Rafotel.Domain
{
    public class Room : Entity
    {
        public string roomNumber { get; set; }
        public bool isLocked { get; set; }
        public bool isReserved { get; set; }
        public RoomTypeEnum rommType { get; set; }

    }
}
