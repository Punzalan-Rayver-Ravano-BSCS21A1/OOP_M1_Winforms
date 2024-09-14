namespace WinFormsApp1
{
    public static class StudentManager
    {
        static IStudentRepository? repository;
        public static IStudentRepository Create()
        {
            repository ??= new StudentRepository();

            return repository;
        }
    }
}
