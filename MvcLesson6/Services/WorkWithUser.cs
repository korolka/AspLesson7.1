using MvcLesson6.Models;

namespace MvcLesson6.Services
{
    public class WorkWithUser : IWorkWithUser
    {
        User user;

        public void InitializeUser(string name, string password, string phone, string email, DateTime birthDay, string surName)
        {
            user = new User() { Name = name, SurName = surName, Phone = phone, Password = password, Email = email, BirthDay = birthDay };
        }

        public bool CheckAge(DateTime birthDay)
        {
            TimeSpan days = DateTime.Now.Subtract(birthDay);
            double age = days.TotalDays / 365;
            if (age == null || age < 16) return false;
            else
            {
                return true;
            }
        }
    }
}
