using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TALARII.Models;

namespace TALARII.Controllers
{
    public class HomeController : Controller
    {
        

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CardList()
        {
            return View();
        }


    }
}