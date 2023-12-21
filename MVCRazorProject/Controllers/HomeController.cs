using Microsoft.AspNetCore.Mvc;
using MVCRazorProject.Models;
using System.Diagnostics;

namespace MVCRazorProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Register()
        {
            
            return View();
        }

        public IActionResult Ornek1()
        {
            User user = new User();
            user.Ad = "burak";
            user.Soyad = "gunce";
            user.KullaniciAdi = "bg61";
            return View(user);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}