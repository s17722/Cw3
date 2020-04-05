using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cw3.Models;

namespace Cw3.DAL
{
    public interface IDbService
    {
        public IEnumerable<Student> GetStudents();

        public List<Student> AddStudent(Student s);

        public List<Student> RemoveStudent(int id);

        public void UpdateStudent(Student s, int id);
    }
}
