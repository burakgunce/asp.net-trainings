using Microsoft.AspNetCore.Mvc;

namespace ActionResultTypes.Controllers
{
    public class FileResultController : Controller
    {
        public IActionResult Index()
        {
            //return RedirectToAction("Index", "Home");
            //return Redirect("/Home/Index");
            //return Redirect("url: /Home/Index");
            return View();
        }

        public FileResult FileContent()
        {
            return File("~/files/C/", "application.pdf");
        }
    }
}
