using Microsoft.AspNetCore.Mvc;

namespace ActionResultTypes.Controllers
{
    public class ContentResultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetContentResult()
        {
            string content = "hello contentresult";
            return Content(content, "text/plain", System.Text.Encoding.UTF8);

            string content2 = "<!DOCTYPE html>" + "<html lang = 'en'>" ;// devamı gee html kodları
            ContentResult contentResult = new ContentResult();
            contentResult.Content = content2;
            contentResult.ContentType = "text/html";
            return contentResult;

        }

        public IActionResult EmptyContent()
        {
            return new EmptyResult();
        }
    }
}
