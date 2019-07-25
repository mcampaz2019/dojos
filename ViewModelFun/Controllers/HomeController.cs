using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ViewModelFun.Models;

namespace ViewModelFun.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var modelMessage = "What's with the --no-https?"+
                        "By default, ASP will want to run your web applications using HTTPS."+ 
                        "This is great for security, but will create some friction upfront - "+
                        "as you would need to then generate https certs for your local browsers. "+
                        "For now, it's best to turn this option off.";
            return View("Index", modelMessage);
        }

        [HttpGet("numbers")]
        public IActionResult Numbers()
        {
            int[] myNumbers = new int[]{1,1,2,3,5,8,13};
            return View("Numbers", myNumbers);
        }

        [HttpGet("user")]
        public IActionResult User()
        {
            User student = new User()
            {
                FirstName = "Mario",
                LastName = "Campaz"
            };
            return View("User", student);
        }

        [HttpGet("users")]
        public IActionResult Users()
        {
            User student1 = new User()
            {
                FirstName = "Mario",
                LastName = "Campaz"
            };
            User student2 = new User()
            {
                FirstName = "Pedro",
                LastName = "Pelaez"
            };
            User student3 = new User()
            {
                FirstName = "Martin",
                LastName = "Roman"
            };
            List<User> students = new List<User>()
            {
                student1, student2, student3
            };
            return View("Users", students);
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
