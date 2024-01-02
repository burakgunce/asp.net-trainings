using Microsoft.AspNetCore.Mvc;
using StateManagement.Models;

namespace StateManagement.Controllers
{
    public class QueryStringController : Controller
    {
        public IActionResult Index(int userId, string userName, string password)
        {
            int _userId = int.Parse(HttpContext.Request.Query["userId"].ToString());
            string _userName = HttpContext.Request.Query["userName"].ToString();
            string _password = HttpContext.Request.Query["password"].ToString();

            User user = new User()
            {
                Id = _userId,
                Name = userName,
                Password = password
            };
            return View(user);
        }
    }
}
