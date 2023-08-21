using Demo1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq; 

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

        public ViewResult Details1() 
        {
            ITIContext context = new ITIContext();

            Student std = context.Students.FirstOrDefault(a => a.Id == 1); 
            return View(std); 
        }
    }
}
