using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Net.Mail;

namespace PassDataToView.Controllers
{
    public class MailController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string txtEmail, string txtKonu, string txtMesaj)
        {
            try
            {
                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();

                message.From = new MailAddress("info.contoso.com");
                message.To.Add(new MailAddress(txtEmail));
                message.Subject = txtKonu;
                message.IsBodyHtml = true;
                message.Body = txtMesaj;
                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("user", "password");
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(message);

                ViewBag.Sonuc = "maıl basarılı sekılde gonderıldı";
            }
            catch (Exception ex)
            {

                ViewBag.Sonuc = "hata : " + ex.Message;
            }
            
            return View();
        }


    }
}
