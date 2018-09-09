using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Skeezy.Data;
using Skeezy.Models;
using Microsoft.EntityFrameworkCore;

namespace Skeezy.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var skiTrp = new Event
            {
                Name = "Party Mountain, USA - 2019"
            };

            return View(skiTrp);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
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
