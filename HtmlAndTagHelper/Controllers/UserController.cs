using HtmlAndTagHelper.Models;
using Microsoft.AspNetCore.Mvc;

namespace HtmlAndTagHelper.Controllers
{
    public class UserController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}

        //https://localhost:Portnumber/User/HtmlHelpers
        [HttpGet]
        public IActionResult HtmlHelpers()
        {
            return View();
        }

        [HttpPost]
        public IActionResult HtmlHelpers(User user)
        {
            return View();
        }

        public IActionResult HtmlHelpers2() => View();

        public IActionResult TagHelpers() => View();

        [HttpPost]
        public IActionResult TagHelpers(User user)
        {
            User usernew = new User
            {
                UserName = "testuser",
                Password = "123456"
            };
            
            return View();
            //return View("HtmlHelpers"); istedıgın view a gitmesi için
            //return View("HtmlHelpers", usernew); istedıgın view a gitmesi için
            //return RedirectToAction("HtmlHelpers", "User"); baska adrese yonlendırme dırek oraya

        }
    }
}
