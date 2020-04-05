using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cw3.Models;

namespace Cw3.DAL
{
    public class MockDbService : IDbService
    {
        private static IEnumerable<Student> _students;

        static MockDbService()
        {
            _students = new List<Student>
            {
                new Student{IdStudent=1, FirstName="Jan", LastName="Kowalski"},
                new Student{IdStudent=2, FirstName="Anna", LastName="Malewska"},
                new Student{IdStudent=3, FirstName="Andrzej", LastName="Andrzejewicz"},
            };
        }
        public IEnumerable<Student> GetStudents()
        {
            return _students;
        }

        public List<Student> AddStudent(Student s)
        {
            var List = new List<Student>(_students);
            List.Add(s);
            return List;
        }

        public void UpdateStudent(Student s, int id)
        {
            var tmpList = RemoveStudent(id);
            AddStudent(s);

        }

        public List<Student> RemoveStudent(int id)
        {
            var tmpStudentList = GetStudents().Where(s => s.IdStudent != id).ToList();

 //           var modifiedStudentList = tmpStudentList.Where(s => s.IdStudent == id).ToList();

            return tmpStudentList;

        }
    }
}
