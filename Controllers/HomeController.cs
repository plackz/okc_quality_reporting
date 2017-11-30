using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using okc_quality_reporting.Models;

namespace okc_quality_reporting.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public IActionResult Index()
        {
            return View();
        }

        //
        // GET: /Home/About/
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        //
        // GET: /Home/Contact/
        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        //
        // GET: /Home/Error/
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
