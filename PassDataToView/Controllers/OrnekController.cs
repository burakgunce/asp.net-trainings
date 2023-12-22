using Microsoft.AspNetCore.Mvc;

namespace PassDataToView.Controllers
{
    public class OrnekController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.GetDate = DateTime.Now.ToString();
            ViewBag.Names = new string[] { "aaa", "bbb", "ccc" };

            ViewData["Hour"] = DateTime.Now.ToLongTimeString();
            TempData["Day"] = DateTime.Now.Day;
            return RedirectToAction("Index2");
            //return View();
        }

        public IActionResult Index2()
        {
            return View();
        }


    }
}
