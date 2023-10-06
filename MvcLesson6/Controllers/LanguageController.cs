using Microsoft.AspNetCore.Mvc;
using MvcLesson6.Models;

namespace MvcLesson6.Controllers
{
    public class LanguageController : Controller
    {
        public IActionResult Index()
        {
            List<ProgrammingLanguage> progLang = new List<ProgrammingLanguage>()
            {
                new ProgrammingLanguage {Language = "Html" },
                new ProgrammingLanguage {Language="C#"},
                new ProgrammingLanguage{Language="Java Script"},
                new ProgrammingLanguage{Language = "Java"},
                new ProgrammingLanguage{Language="Python"}
            };
            return View(progLang);
        }
    }
}
