using Microsoft.AspNetCore.Mvc;
using prjAjaxDemo.Models;
using System.Diagnostics;

namespace prjAjaxDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult First()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult GetDemo()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }
        public IActionResult ReadJson()
        {
            return View();
        }

        public IActionResult Travel()
        {
            return View();
        }

        public IActionResult Address()
        {
            return View();
        }

        public IActionResult Promise()
        {
            return View();
        }

        public IActionResult Fetch()
        {
            return View();
        }

        public IActionResult Jquery()
        {
            return View();
        }

        public IActionResult partial1()
        {
            return PartialView();
        }

        public IActionResult Partial2()
        {
            ViewBag.KK = "message from action";
            return PartialView();
        }
        public IActionResult AddressAA()
        {
            return View();
        }
        public IActionResult AutoComplete()
        {
            return View();
        }
    }
}