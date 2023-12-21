using Microsoft.AspNetCore.Mvc;
using VeriTransferi.Models;

namespace VeriTransferi.Controllers
{
    public class LoginController : Controller
    {
        //controller logın sayfası kullanıcı adı ve sıfre
        //eger kullanıcı adı ve sıfre krıterlere uyuyor ıse yenı bır sayfada hos geldınız
        //eger uymuyor ıse aynı sayfa goruntulensın
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(User user)
        {
            User user1 = new User();
            user1.UserName = "bg61";
            user1.Password = "616161";

            if (user.UserName == user1.UserName && user.Password == user1.Password)
            {
                return View("Details", user);
            }
            else
            {
                return View();
            }
        }

        public IActionResult Details()
        {
            return View();
        }


    }
}
