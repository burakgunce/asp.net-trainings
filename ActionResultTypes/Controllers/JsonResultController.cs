using ActionResultTypes.Models;
using Microsoft.AspNetCore.Mvc;

namespace ActionResultTypes.Controllers
{
    public class JsonResultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public JsonResult GetJsonEmployee()
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
            return Json(employee);
        }
    }
}
