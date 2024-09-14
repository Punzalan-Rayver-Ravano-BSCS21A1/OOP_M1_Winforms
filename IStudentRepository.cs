namespace WinFormsApp1
{
    public interface IStudentRepository
    {
        void AddItem(string firstName, string lastName, string section, string course);
        List<Student> GetItems();
    }
}
