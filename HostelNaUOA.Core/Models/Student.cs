using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostelNaUOA.Core
{
    public class Student
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]

        public string Id { get; set; }
        public string StudentName { get; set; }
        public string Faculty { get; set; }
        public int Course { get; set; }
        public string Phone { get; set; }
        public string Description { get; set; }
        public int NumberRoom { get; set; }
        public string RoomSex { get; set; }
        public DateTime DateSettlement { get; set; }
        public DateTime DateEviction { get; set; }
    }
}
