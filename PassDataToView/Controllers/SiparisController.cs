using Microsoft.AspNetCore.Mvc;

namespace PassDataToView.Controllers
{
    public class SiparisController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult UrunSat()
        {
            return View();
        }

        [HttpPost]
        public IActionResult UrunSat(IFormCollection form)
        {
            TempData["UrunId"] = int.Parse(form["UrunId"].ToString());
            TempData["UrunAdi"] = form["UrunAdi"].ToString();
            TempData["UrunFiyati"] = form["UrunFiyati"].ToString();
            return RedirectToAction("StokInfo", "Stok");
        }


    }
}
