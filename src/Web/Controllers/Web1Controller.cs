using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class Web1Controller : Controller
    {
        public IActionResult P2()
        {
            return View();
        }
        public IActionResult ShowText()
        {
            return Content("Chandra Mouli Kantipudi ");
        }
        public IActionResult ShowJSON()
        {
            return Json(new { name = "Mouli", lastName = "Kantipudi" });
        }
        public IActionResult ShowHTML()
        {
            var h = "<!DOCTYPE html><html><body>Chandra Mouli Kantipudi" +
            "<br><br> <a href='/Web1>Go Back</a></body></html>";
            return Content(h, "text/html");
        }

        public IActionResult P2()
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
