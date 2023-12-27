using Microsoft.AspNetCore.Mvc;

namespace ActionResultTypes.Controllers
{
    public class StatusCodeResultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public StatusCodeResult StatusCodeContent()
        {
            return Unauthorized();
            return NotFound();
            return BadRequest();
            return Ok();
            return StatusCode(404);
        }
    }
}
