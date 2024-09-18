namespace WinFormsApp1
{
    public class StudentRepository : IStudentRepository
    {
        readonly List<Student> students;

        public StudentRepository()
        {
            students = [];
        }

        public void AddItem(string firstName, string lastName, string section, string course)
        {
            students.Add(new Student { FirstName = firstName, Course = course, ID = students.Count + 1, LastName = lastName, Section = section });
        }
        public List<Student> GetItems()
        {
            // Instance a list of objects
            return students;
        }

        public void UpdateItem(int id, string firstName, string lastName, string section, string course)
        {
            Student? student = students.Find(x => x.ID == id);
            if (student != null)
            {
                student.FirstName = firstName;
                student.LastName = lastName;
                student.Section = section;
                student.Course = course;
            }
        }
    }
}
