namespace MvcLesson6.Services
{
    public static class Helper
    {
        public static bool CheckAge(int age)
        {
            if (age == null || age < 14)
                return false;
            else
                return true;
        }
    }
}
