using Rafotel.Domain;
using Rafotel.Repository.Base;
using Rafotel.Domain.ValueObject;
using System.Collections.Generic;
using Rafotel.Repository.Interface;

namespace Rafotel.Repository
{
    public class RoomRepository:Repository<Room>
    {
        private IList<Room> _room;

        public RoomRepository()
        {
            _room = new List<Room>();
        }



    }
}
