using ActionResultTypes.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ActionResultTypes.Controllers
{
    public class HomeController : Controller
    {
        /*
         * Action kısıtlar
         * 1- public olmalı
         * 2- static olamazlar
         * 3- ref yada out parametre alamaz
         * 
         * Action geri donus tipleri
         * 1- ViewResult
         * 2- PartialViewResult
         * 3- ContentResult
         * 4- EmptyResult
         * 5- JsonResult
         * 6- StatusCodeResult
         * 7- FileResult
         * 8- RedirectToAction
         * 9- RedirectResult
         * 10- JavaScriptResult
         */
        
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            Employee employee = new Employee 
            {
                EmployeeId = 1,
                FirstName = "aaa",
                LastName = "bbb",
                Email = "aa.bbb@hm.com",
                Address = new Address
                {
                    AddressId = 1,
                    City = "London",
                    Country = "England",
                    AddressDetail = "1234 street"
                }
            };
            return View("EmployeeDetail", employee);
        }

        public IActionResult Privacy()
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