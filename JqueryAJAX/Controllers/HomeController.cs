using JqueryAJAX.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace JqueryAJAX.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public int Add(int number1, int number2)
        {
            int total = number1 + number2;
            return total;
        }

        public CalculateNumbers Calculate (int  number1, int number2)
        {
            CalculateNumbers calculate = new CalculateNumbers ();
            calculate.Add = number1 + number2;
            calculate.Substract = number1 - number2;
            calculate.Multiplier = number1 * number2;
            calculate.Divide = number1 / number2;
            return calculate;
        }
        public IActionResult Index()
        {
            return View();
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