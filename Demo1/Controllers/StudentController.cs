using Microsoft.AspNetCore.Mvc;

namespace Demo1.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string Show()
        {
            return "Hello MVC";
        }

        public int Add()
        {
            return 20;
        }
    }
}
