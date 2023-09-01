using Microsoft.AspNetCore.Mvc;

namespace prjAjaxDemo.Controllers
{
    public class AzController : Controller
    {
        public IActionResult Index()
        {
            //    https://westus.dev.cognitive.microsoft.com/docs/services
            return View();
        }

        public IActionResult VisionUpload()
        {
            return View();
        }
        public IActionResult ContentModerator()
        {
            return View();
        }
        public IActionResult TextModerator()
        {
            return View();
        }
    }
}
