using Microsoft.AspNetCore.Mvc;
using MyProjet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProjet.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Articles artc)
        {
            return View();
        }

    }
}
