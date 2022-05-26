using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostelNaUOA.Core
{
    public class RoomServices : IRoomServices
    {
        private readonly IMongoCollection<Room> _room;
        public RoomServices(IDbClient dbClient)
        {
            _room = dbClient.GetRoomCollection();
        }
        public Room AddRoom(Room room)
        {
            _room.InsertOne(room);
            return room;
        }

        public void DeleteRoom(string id)
        {
            _room.DeleteOne(room => room.Id == id);
        }

        public List<Room> GetRoom() => _room.Find(room => true).ToList();

        public Room GetRoom(string id) => _room.Find(room => room.Id == id).First();

        public Room UpdateRoom(Room room)
        {
            GetRoom(room.Id);
            _room.ReplaceOne(r => r.Id == room.Id, room);
            return room;
        }
    }
}
