using Microsoft.AspNetCore.Mvc;
using PartialView.Models;

namespace PartialView.Controllers
{
    public class ProductController : Controller
    {
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

        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Details(int id)
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

            Product product = products.Where(x => x.ProductId == id).FirstOrDefault();
            return View();
        }

    }
}
