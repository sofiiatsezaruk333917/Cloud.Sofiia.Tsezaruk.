using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostelNaUOA.Core
{
   public class HostelDbConfig
    {
        public string Database_Name { get; set; }
        public string Hostel_Collection_Name { get; set; }
        public string Student_Collection_Name { get; set; }
        public string Room_Collection_Name { get; set; }

        public string Connection_String { get; set; }
    }
}
