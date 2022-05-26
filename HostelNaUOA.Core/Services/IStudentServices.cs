using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostelNaUOA.Core
{
    public interface IStudentServices
    {
        List<Student> GetStudent();
        Student GetStudent(string id);
        Student AddStudent(Student student);
        void DeleteStudent(string id);
        Student UpdateStudent(Student student);
    }
}
