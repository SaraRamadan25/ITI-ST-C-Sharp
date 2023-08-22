using Demo1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq; 

namespace Demo1.Controllers
{
    public class StudentController : Controller
    {
        ITIContext db = new ITIContext();

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]

        public IActionResult Create(Student model) {

            db.Students.Add(model);

            db.SaveChanges();

            return RedirectToAction("Index");
        }

      

      public IActionResult Index()
        {
            var model = db.Students.ToList();
            return View(model);

        }

        public IActionResult Details(int id)
        {
            Student student= db.Students.FirstOrDefault(a=>a.Id == id);
            if (student == null)
            return new NotFoundResult();

            return View(student);
        }


    }
}
