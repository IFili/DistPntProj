using Cargo4You_Project.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Cargo4You_Project.Controllers
{
    public class HomeController : Controller
    {


        public HomeController()
        {

        }

        public IActionResult Index()
        {
            return View();
        }



       // [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]

    }
}