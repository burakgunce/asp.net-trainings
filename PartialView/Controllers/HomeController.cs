using Microsoft.AspNetCore.Mvc;
using PartialView.Models;
using System.Diagnostics;

namespace PartialView.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<Product> products = new List<Product>
            {
                new Product { ProductId = 1, ProductName = "Product 1", 
                    CategoryName = "Category 1", Description = "Description 1", Price = 10.50M},
                new Product { ProductId = 2, ProductName = "Product 1", 
                    CategoryName = "Category 2", Description = "Description 2", Price = 10.50M},
                new Product { ProductId = 3, ProductName = "Product 1", 
                    CategoryName = "Category 2", Description = "Description 3", Price = 10.50M},
                new Product { ProductId = 4, ProductName = "Product 1", 
                    CategoryName = "Category 2", Description = "Description 4", Price = 10.50M}

            };
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