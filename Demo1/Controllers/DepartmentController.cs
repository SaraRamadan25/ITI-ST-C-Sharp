using Demo1.BLL;
using Demo1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Demo1.Controllers
{
    public class DepartmentController : Controller
    {
        DepartmentBLL db = new DepartmentBLL();

        [HttpGet]
        public IActionResult Create()

        {
            DepartmentBLL deptbll = new DepartmentBLL();
            ViewBag.departments = deptbll.GetAll();
            return View();
        }

        [HttpPost]
        public IActionResult Create(Department model)
        {
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
            Department department = db.GetById(id);
            if (department == null)
                return new NotFoundResult();
            return View(department);
        }

        public IActionResult Edit(int? id)
        {
            if (id == null)
                return BadRequest();
            Department department = db.GetById(id.Value);
            if (department == null)
                return NotFound();
            return View(department);
        }

        [HttpPost]
        public IActionResult Edit(Department department)
        {
            db.Update(department);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
                return BadRequest();
            Department department = db.GetById(id.Value);
            if (department == null)
                return NotFound();
            return View(department);
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
