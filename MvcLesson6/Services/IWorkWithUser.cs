namespace MvcLesson6.Services
{
    public interface IWorkWithUser
    {
        void InitializeUser(string name, string password, string phone, string email, DateTime birthDay, string surName);
        bool CheckAge(DateTime birthDay);
    }
}
