using Microsoft.AspNetCore.Mvc;

namespace mvc1.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details()
        {
            //Response.Cookies.Append("Id", "9");
            //Response.Cookies.Append("name", "sara");

            HttpContext.Session.SetInt32("id", 9);
            HttpContext.Session.SetString("name", "Sara Ramadan");

            ViewBag.id = 9;
            ViewBag.name = "sara";
            return View();
        }

        public IActionResult Display()
        {
            //int id = int.Parse(Request.Cookies["id"]);
            //string name = Request.Cookies["name"];
            int? id = HttpContext.Session.GetInt32("id");
            string name = HttpContext.Session.GetString("name");
            ViewBag.id = id;
            ViewBag.name = name;
            return View();
        }
    }
}