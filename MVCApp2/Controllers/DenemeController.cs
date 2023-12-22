using Microsoft.AspNetCore.Mvc;

namespace MVCApp2.Controllers
{
    public class DenemeController : Controller
    {
        public IActionResult Index()
        {
            //bugunun tarıhını vıewdata ıle adınız soyadını vıewbag ıle suan ın saatını tempdata ıle vıew de goruntule
            ViewData["tarih"] = DateTime.Now.ToShortDateString();
            ViewBag.AdSoyad = "burak gunce";
            TempData["saat"] = DateTime.Now.Hour;

            //basak bır actıon olusturup ıcınde bulundugumuz ayı baska bır actın da kullan
            //TempData["ay"] = DateTime.Now.Month;
            return View();
        }

        public IActionResult Index2()
        {
            TempData["ay"] = DateTime.Now.Month;
            return View();
        }

        public IActionResult Index3()
        {
            int buAy = (int)TempData["ay"];
            return View();
        }

        //baska bır controller olusturun kullanıcıdan urunıd marka ve model bılgılerını al bunu actıon a ıform collectıon ıle getır

        public IActionResult Index4()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Index4(IFormCollection form)
        {
            TempData["UrunId"] = int.Parse(form["UrunId"]);
            TempData["Marka"] = form["Marka"].ToString();
            TempData["Model"] = form["Model"].ToString();
            return View();
        }
        public IActionResult Index5()
        {
            int id = (int)TempData["UrunId"];
            string model = TempData["Marka"].ToString();
            string marka = TempData["Model"].ToString();
            return View();
        }
    }
}
