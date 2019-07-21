using Rafotel.Business.Interfaces;
using Rafotel.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rafotel.Services
{
    public class RoomServices
    {
        //Create a generic business var
        private readonly IRoomBusiness _roomBusiness;

        public RoomServices(IRoomBusiness roomBusiness)
        {
            _roomBusiness = roomBusiness;
        }

        public List<Room> Insert(Room room)
        {
            _roomBusiness.Add(room);
            return _roomBusiness.GetList();
        }


    }
}
