using Microsoft.AspNetCore.Mvc;
using MvcLesson6.Models;
using MvcLesson6.Services;

namespace MvcLesson6.Controllers
{
    public class HomeController : Controller
    {
        IWorkWithUser workWithUser;
        public HomeController(IWorkWithUser workWithUser)
        {
            this.workWithUser = workWithUser;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Register(string name,string password,string phone,string email,DateTime birthDay, string surName)
        {

            workWithUser.InitializeUser(name,password,phone,email, birthDay, surName);
            if (!workWithUser.CheckAge(birthDay))
            {
                return View("Error");//very young TODO
            }
            return View();
        }

        public IActionResult ChooseQuontity(int quontity)
        {
            return View("PlaceOrder",quontity);
        }

        public IActionResult ConfirmOrder(Product[] orders)
        {

            return View(orders);
        }


        public IActionResult Error()
        {
            return View();
        }

    }
}
