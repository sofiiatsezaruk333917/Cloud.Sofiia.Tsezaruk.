using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostelNaUOA.Core
{
   public interface IDbClient
    {
        IMongoCollection<Hostel> GetHostelCollection();
        IMongoCollection<Room> GetRoomCollection();
        IMongoCollection<Student> GetStudentCollection();
    }
}
