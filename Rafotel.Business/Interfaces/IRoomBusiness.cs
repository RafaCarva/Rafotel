using Rafotel.Domain;
using System.Collections.Generic;

namespace Rafotel.Business.Interfaces
{
    public interface IRoomBusiness
    {
        bool Add(Room room);
        List<Room> GetList();
    }
}
