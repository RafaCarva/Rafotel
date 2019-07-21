using Rafotel.Business.Interfaces;
using Rafotel.Domain;
using System;
using System.Collections.Generic;
using Rafotel.Repository;
using Rafotel.Repository.Interface;

namespace Rafotel.Business
{
    class RoomBusiness : IRoomBusiness
    {
        //Create a generic Repository 
        private IRepository<Room> _roomRepository;

        public RoomBusiness(IRepository<Room> roomRepository)
        {
            _roomRepository = roomRepository;
        }

        public bool Add(Room room)
        {
            return _roomRepository.Add(room);
        }

        public List<Room> GetList()
        {
            return _roomRepository.GetList();
        }


    }
}
