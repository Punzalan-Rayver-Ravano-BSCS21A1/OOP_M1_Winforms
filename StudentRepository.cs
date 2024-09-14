using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{

    public class DbRepository : IStudentRepository
    {
        public void AddItem(string firstName, string lastName, string section, string course)
        {
            throw new NotImplementedException();
        }

        public List<Student> GetItems()
        {
            throw new NotImplementedException();
        }
    }
    public class StudentRepository : IStudentRepository
    {
        readonly List<Student> students = new();

        public void AddItem(string firstName, string lastName, string section, string course)
        {
            students.Add(new Student { FirstName = firstName, Course = course, ID = students.Count + 1, LastName = lastName, Section = section });
        }
        public List<Student> GetItems()
        {
            // Create a list of objects
            return students;
        }
    }
}
