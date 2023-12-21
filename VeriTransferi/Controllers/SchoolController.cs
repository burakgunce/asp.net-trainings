using Microsoft.AspNetCore.Mvc;
using VeriTransferi.Models;

namespace VeriTransferi.Controllers
{
    public class SchoolController : Controller
    {
        //bır tane  controllerınız olsun default da bu controllerın ındex sayfası acılsın
        //bu sayfada model ıle school datalarını alın ıd ad sehır
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(School school)
        {
            return View();
        }



        
        public IActionResult Add()
        {
            return View();
        }
    }
}
