using Demo1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq; 

namespace Demo1.Controllers
{
    public class DepartmentController : Controller
    {
        ITIContext db = new ITIContext();

        public IActionResult Index()
        {
            var model = db.Departments.ToList();
            return View(model);
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Create(Department model)
        {

            db.Departments.Add(model);

            db.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            Department department = db.Departments.FirstOrDefault(a => a.Id == id);
            if (department == null)
                return new NotFoundResult();

            return View(department);
        }
    }
}
