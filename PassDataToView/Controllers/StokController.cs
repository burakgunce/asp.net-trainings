using Microsoft.AspNetCore.Mvc;

namespace PassDataToView.Controllers
{
    public class StokController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult StokInfo()
        {
            int urunId = int.Parse(TempData["UrunId"].ToString());
            string urunAdi = TempData["UrunAdi"].ToString();
            string urunFiyati = TempData["UrunFiyati"].ToString();

            ViewBag.UrunId = urunId;
            ViewBag.UrunAdi = urunAdi;
            ViewBag.UrunFiyati = urunFiyati;
            return View();
        }
    }
}
