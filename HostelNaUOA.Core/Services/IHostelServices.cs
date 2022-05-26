using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostelNaUOA.Core
{
    public interface IHostelServices
    {
        List<Hostel> GetHostels();
        Hostel GetHostel(string id);
        Hostel AddHostel(Hostel hostel);
        void DeleteHostel(string id);
        Hostel UpdateHostel(Hostel hostel);
    }
}
