using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostelNaUOA.Core
{
    public class DbClient : IDbClient
    {
        private readonly IMongoCollection<Hostel> _hostel;
        private readonly IMongoCollection<Student> _student;
        private readonly IMongoCollection<Room> _room;


        public DbClient(IOptions<HostelDbConfig> hostelDbConfig)
        {
            var client = new MongoClient(hostelDbConfig.Value.Connection_String);
            var database = client.GetDatabase(hostelDbConfig.Value.Database_Name);
            _hostel = database.GetCollection<Hostel>(hostelDbConfig.Value.Hostel_Collection_Name);
            _student = database.GetCollection<Student>(hostelDbConfig.Value.Student_Collection_Name);
            _room = database.GetCollection<Room>(hostelDbConfig.Value.Room_Collection_Name);
        }

        public IMongoCollection<Hostel> GetHostelCollection()
        {
            return _hostel;
        }


        public IMongoCollection<Room> GetRoomCollection()
        {
            return _room;
        }

        public IMongoCollection<Student> GetStudentCollection()
        {
            return _student;
        }
    }
}
