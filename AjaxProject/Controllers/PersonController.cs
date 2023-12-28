using AjaxProject.Context;
using AjaxProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace AjaxProject.Controllers
{
    public class PersonController : Controller
    {
        AppDbContext db;
        public PersonController(AppDbContext dbContext)
        {
            db = dbContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetAllPeople()
        {
            List<Person> people = db.People.ToList();
            return PartialView("_AllPeoplePartial", people);
        }

        public IActionResult Create()
        {
            return PartialView("_CreatePartial");
        }

        [HttpPost]
        public IActionResult Create(Person person)
        {
            db.Add(person);
            bool isAdded = db.SaveChanges() > 0;
            if (isAdded)
            {
                return Json("ok");
            }
            return Json("fail");
        }

        public IActionResult Update(int id)
        {
            Person person = db.People.Find(id);
            return PartialView("_UpdatePartial", person);
        }

        [HttpPost]
        public IActionResult Update(Person person)
        {
            db.People.Update(person);
            bool isUpdated = db.SaveChanges() > 0;
            if (isUpdated)
            {
                return Json("ok");
            }
            return Json("fail");
        }

        public IActionResult Delete(int id)
        {
            Person person = db.People.Find(id);
            db.People.Remove(person);
            if (db.SaveChanges() > 0)
            {
                return Json("ok");
            }
            return Json("fail");
        }
    }
}
