using Microsoft.AspNetCore.Mvc;

namespace prjAjaxDemo.Controllers
{
    public class HomeworkController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult HW1()
        {
            return View();
        }
        public IActionResult HW2()
        {
            return View();
        }
    }
}
