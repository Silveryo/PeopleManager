using Microsoft.AspNetCore.Mvc;
using PeopleManager.Ui.WebApp.Models;
using System.Diagnostics;

namespace PeopleManager.Ui.WebApp.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            var people = GetPeople();
            return View(people);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        private IList<Person> GetPeople()
        {

            return new List<Person>
            {
                new()
                {
                    FirstName = "Bavo",
                    LastName = "Ketels",
                    Description = "This is the description of the person",
                    Email = "bavo.ketels@vives.be"
                },
                new()
                {
                    FirstName = "Zdeněk",
                    LastName = "Odehnal",
                    Description = "This is the description of the person",
                    Email = "zdenek.odehnal@student.vives.be"
                }
            };
        }
    }
}