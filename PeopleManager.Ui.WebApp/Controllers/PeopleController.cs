using Microsoft.AspNetCore.Mvc;

namespace PeopleManager.Ui.WebApp.Controllers
{
    public class PeopleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
