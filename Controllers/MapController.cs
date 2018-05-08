using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BEE.Models;

namespace BEE.Controllers
{
    public class MapController : Controller
    {
        [HttpGet]
        [Route("map")]
        public IActionResult Places()
        {
            return View("Places");
        }



        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
