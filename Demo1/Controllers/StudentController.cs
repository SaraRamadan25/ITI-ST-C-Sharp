using Demo1.BLL;
using Demo1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Demo1.Controllers
{
    public class StudentController : Controller
    {
        StudentBLL db = new StudentBLL();

        [HttpGet]
        public IActionResult Create()
        {
            DepartmentBLL deptbll = new DepartmentBLL();
            ViewBag.departments = deptbll.GetAll();
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student model)
        {
            if(ModelState.IsValid)
            db.Add(model);
            return RedirectToAction("Index");
        }

        public IActionResult Index()
        {
            var model = db.GetAll();
            return View(model);
        }

        public IActionResult Details(int id)
        {
            Student student = db.GetById(id);
            if (student == null)
                return new NotFoundResult();
            return View(student);
        }

        public IActionResult Edit(int? id)
        {
            if (id == null)
                return BadRequest();
            Student student = db.GetById(id.Value);
            if (student == null)
                return NotFound();
            return View(student);
        }

        [HttpPost]
        public IActionResult Edit(Student student)
        {
            db.Update(student);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            Student student = db.GetById(id.Value);
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }

        [HttpPost]
        [ActionName("Delete")]
        public IActionResult DeleteConfirmed(int? id)
        {
            if (id == null)
                return BadRequest();
            db.Delete(id.Value);
            return RedirectToAction("Index");
        }
    }
}
