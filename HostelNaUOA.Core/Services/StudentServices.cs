using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostelNaUOA.Core
{
    public class StudentServices : IStudentServices
    {
        private readonly IMongoCollection<Student> _student;

        public StudentServices(IDbClient dbClient)
        {
            _student = dbClient.GetStudentCollection();
        }
        public Student AddStudent(Student student)
        {
            _student.InsertOne(student);
            return student;
        }

        public void DeleteStudent(string id)
        {
            _student.DeleteOne(student => student.Id == id);
        }

        public List<Student> GetStudent() => _student.Find(student => true).ToList();

        public Student GetStudent(string id) => _student.Find(student => student.Id == id).First();

        public Student UpdateStudent(Student student)
        {
            GetStudent(student.Id);
            _student.ReplaceOne(s => s.Id == student.Id, student);
            return student;
        }


    }
}
