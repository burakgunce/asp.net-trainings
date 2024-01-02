using Microsoft.AspNetCore.Mvc;

namespace StateManagement.Controllers
{
    public class CookieController : Controller
    {
        public IActionResult Index()
        {
            HttpContext.Response.Cookies.Append("AppName", "Bmw");
            HttpContext.Response.Cookies.Append("PersonName", "John Doe");
            HttpContext.Response.Cookies.Append("PersonAge", "30");
            HttpContext.Response.Cookies.Append("PersonMail", "jd@hotmail.com");
            HttpContext.Response.Cookies.Append("RoleName", "User");
            return View();
        }

        public IActionResult ShowCookie()
        {
            ViewBag.Firm = GetCookieVal("AppName");
            ViewBag.PersonName = GetCookieVal("PersonName");
            ViewBag.PersonAge = GetCookieVal("PersonAge");
            ViewBag.PersonMail = GetCookieVal("PersonMail");
            ViewBag.RoleName = GetCookieVal("RoleName");
            return View();

        }

        public string GetCookieVal(string key)
        {
            HttpContext.Request.Cookies.TryGetValue(key, out var sonuc);
            return sonuc;
        }
    }
}
