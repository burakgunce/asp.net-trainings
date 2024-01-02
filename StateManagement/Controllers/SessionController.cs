using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace StateManagement.Controllers
{
    public class SessionController : Controller
    {
        public IActionResult Index()
        {
            HttpContext.Session.SetString("Firm", "Bmw");
            HttpContext.Session.SetString("PersonName", "John Doe");
            HttpContext.Session.SetInt32("PersonAge", 30);
            HttpContext.Session.SetString("PersonMail", "jd@hotmail.com");
            HttpContext.Session.SetString("RoleName", "User");
            return View();
        }

        public IActionResult ShowSession()
        {
            ViewBag.Firm = HttpContext.Session.GetString("Firm");
            ViewBag.PersonName = HttpContext.Session.GetString("PersonName");
            ViewBag.PersonAge = HttpContext.Session.GetInt32("PersonAge");
            ViewBag.PersonMail = HttpContext.Session.GetString("PersonMail");
            ViewBag.RoleName = HttpContext.Session.GetString("RoleName");
            return View();
        }

        //HttpContext.Session.Clear(); Session verilerini temizler
    }
}
