using Microsoft.AspNetCore.Mvc;
using MVCCore_Model_ViewModel.Models;
using MVCCore_Model_ViewModel.Models.Enums;
using MVCCore_Model_ViewModel.Models.VM;

namespace MVCCore_Model_ViewModel.Controllers
{
    public class PersonelController : Controller
    {
        List<Personel> personeller = new List<Personel>
        {
            new Personel {PersonelId = 1, Name="aaa", BirthDate = new DateTime(2000,01,02),
            WorkingType = WorkingType.FullTime},
            new Personel {PersonelId = 2, Name="bbb", BirthDate = new DateTime(1995,01,02),
            WorkingType = WorkingType.FullTime},
            new Personel {PersonelId = 3, Name="ccc", BirthDate = new DateTime(1990,01,02),
            WorkingType = WorkingType.FullTime},
            new Personel {PersonelId = 4, Name="ddd", BirthDate = new DateTime(1985,01,02),
            WorkingType = WorkingType.FullTime}
        };

        List<Department> departmanlar = new List<Department>()
        {
            new Department {DepartmentId = 1, DepartmentName= "Yazılım"},
            new Department {DepartmentId = 2, DepartmentName= "Muhasebe"},
            new Department {DepartmentId = 3, DepartmentName= "Donanım"},
            new Department {DepartmentId = 4, DepartmentName= "IT"},
            new Department {DepartmentId = 5, DepartmentName= "IK"},
        };

        public IActionResult Index()
        {
            return View(personeller);
        }

        [HttpGet]
        public IActionResult Create()
        {
            CreatePersonelVM personelVM = new CreatePersonelVM();
            personelVM.Personel = new Personel();
            personelVM.Deparments = departmanlar;

            return View(personelVM);
        }

        [HttpPost]
        public IActionResult Create(Personel personel)
        {
            personeller.Add(personel);
            return View("Index", personeller);
        }
    }
}
