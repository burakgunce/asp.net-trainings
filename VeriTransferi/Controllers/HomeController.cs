using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using VeriTransferi.Models;

namespace VeriTransferi.Controllers
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

        public IActionResult Giris(string email, string password)
        {
            return View();
        }

        /*isim soyisim dogum tarıhı cınsıyet(radıo) ogrenım durumu(combobox) medenı durumu(checkbox evli)
         */

        public IActionResult Ornek1(string isim, string soyisim, DateTime dogum, string cinsiyet,
            string ogrenimdurumu, string medenidurum)
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}