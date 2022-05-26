using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostelNaUOA.Core
{
    public class Room
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]

        public string Id { get; set; }
        public string Description { get; set; }
        public int NumberRoom { get; set; }
        public int BedCount { get; set; }
        public int StudentCount { get; set; }
        public int FreeBedCount { get; set; }
        public string RoomSex { get; set; }
    }
}
