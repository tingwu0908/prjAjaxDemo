using Microsoft.AspNetCore.Mvc;
using prjAjaxDemo.ViewModels;
using prjAjaxDemo.Models;


namespace prjAjaxDemo.Controllers
{
    public class ApiController : Controller
    {

        private readonly DemoContext _context;
        private readonly IWebHostEnvironment _host;

        public ApiController(DemoContext context, IWebHostEnvironment host)
        {
            _context = context;
            _host = host;
        }

        public IActionResult Index()
        {
            System.Threading.Thread.Sleep(5000);
            return Content("Hello Ajax!");
        }
        public IActionResult GetDemo(UserViewModel user)
        {
            if (string.IsNullOrEmpty(user.name))
            {
                user.name = "guest";
            }
            return Content($"Hello {user.name}!  {user.age}y");
        }
        public IActionResult Register(Members member, IFormFile file)
        {



            //將檔案上傳至uploads資料夾
            string filePath = Path.Combine(_host.WebRootPath, "uploads", file.FileName);
            using(var fileStream = new FileStream(filePath, FileMode.Create))
            {
                file.CopyTo(fileStream);
            }

            //將檔案轉為二進位資料並存入資料庫
            byte[] photo = null;
            using (var fileStream = new MemoryStream())
            {
                file.CopyTo(fileStream);
                photo = fileStream.ToArray();
            }

            member.FileName = file.FileName;
            member.FileData = photo;

            _context.Members.Add(member);
            _context.SaveChanges();
            return Content("新增成功！");
        }

        public bool CheckAccount(vmCheckName vm)
        {
            return _context.Members.Any(m => m.Name == vm.txtName);
        }
    }
}
