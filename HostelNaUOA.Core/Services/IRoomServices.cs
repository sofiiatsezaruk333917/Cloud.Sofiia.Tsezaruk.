using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostelNaUOA.Core
{
    public interface IRoomServices
    {
        List<Room> GetRoom();
        Room GetRoom(string id);
        Room AddRoom(Room room);
        void DeleteRoom(string id);
        Room UpdateRoom(Room room);
    }
}
