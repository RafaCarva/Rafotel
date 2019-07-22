using Moq;
using Rafotel.Business.Interfaces;
using Rafotel.Domain;
using Rafotel.Services;
using Rafotel.Domain.ValueObject;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Rafotel.Services.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var roomBusinessMock = new Mock<IRoomBusiness>();
            roomBusinessMock.Setup(a=>a.Add(It.IsAny<Room>())).Returns(true);

            var roomExpectancy = new List<Room>
            {
                new Room(){roomNumber="1", isLocked=false,isReserved=false,roomType=RoomTypeEnum.Single},
                new Room(){roomNumber="2", isLocked=false,isReserved=false,roomType=RoomTypeEnum.Lux}
            };

            roomBusinessMock.Setup(a => a.GetList()).Returns(roomExpectancy);

            var roomService = new RoomServices(roomBusinessMock.Object);
            var rooms = roomService.Insert(null);

            Assert.NotNull(rooms);
            Assert.True(rooms.Any());

            for (var index=0; index < rooms.Count ;index++)
            {
                Assert.Equal(roomExpectancy[index].roomNumber, rooms[index].roomNumber);
                Assert.Equal(roomExpectancy[index].isLocked, rooms[index].isLocked);
                Assert.Equal(roomExpectancy[index].isReserved, rooms[index].isReserved);
                Assert.Equal(roomExpectancy[index].roomType, rooms[index].roomType);
            }
        }
    }
}
