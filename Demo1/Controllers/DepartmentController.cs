using Demo1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq; 

namespace Demo1.Controllers
{
    public class DepartmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ViewResult Details2() 
        {
            ITIContext context = new ITIContext();

            Department department = context.Departments.FirstOrDefault(b => b.Id == 1);
            return View(department); 
        }
    }
}
