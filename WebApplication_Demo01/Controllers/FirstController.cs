using Microsoft.AspNetCore.Mvc;
using WebApplication_Demo01.Models;
namespace WebApplication_Demo01.Controllers
{
    public class FirstController : Controller
    {
        public string Index()
        {
            return "Hello World";
        }
        public IActionResult Hello()
        {
            ViewBag.Message = "Hello World";
            return View();
        }
        public IActionResult Info()
        {
            Person person = new Person();
            person.Name = "John";
            person.Age = 18;
            person.Location = "United States";
            return View(person);
        }
    }
}
