using Microsoft.AspNetCore.Mvc;
using MvcLesson6.Models;
using MvcLesson6.Services;

namespace MvcLesson6.Controllers
{
    public class RegistredController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Registration(UserEx2 user)
        {
            if (!Helper.CheckAge(user.Age))
            {
                return View("Error");

            }
            return View("Success");
        }
    }
}
