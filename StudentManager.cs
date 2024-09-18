namespace WinFormsApp1
{
    public static class StudentManager
    {
        static IStudentRepository? repository;
        public static IStudentRepository Instance()
        {
            repository ??= new StudentRepository();

            return repository;
        }
    }
}
