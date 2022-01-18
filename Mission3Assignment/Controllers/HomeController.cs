using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Mission3Assignment.Models;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Mission3Assignment.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<Home>/
        public IActionResult Index()
        {
            return View();
        }

        // GET: /<Calculator>/
        [HttpGet]
        public IActionResult Calculator()
        {
            return View();
        }

        //POST for calculator page
        [HttpPost]
        public IActionResult Calculator(CalculatorModel model)
        {
            return View();
        }

    }
}
