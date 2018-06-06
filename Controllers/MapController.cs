using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BEE.Models;
using Microsoft.EntityFrameworkCore;

namespace BEE.Controllers
{
    public class MapController : Controller
    {
        private BeeContext _context;
        public MapController( BeeContext context )
        {
            _context = context;
        }

        [HttpGet]
        [Route("map")]
        public IActionResult Places()
        {
            List<hive> AllHives = _context.hives.ToList();                      
            ViewBag.allhives= AllHives;

             List<string> alladdresses = new List<string>();
            foreach(var g in AllHives){
                alladdresses.Add(g.hiveAddress +", "+ g.hiveCity +", "+  g.hiveState +", "+ g.hiveZip);
            }
            ViewBag.hiveaddresses= alladdresses;

            return View("Places");
        }
        // [HttpGet]
        // [Route("getlocations")]
        // public IActionResult GetLocations()
        // {
        //     List<hive> AllHives = _context.hives.ToList();                       
        //     ViewBag.allhives= AllHives;
        //      List<string> alladdresses = new List<string>();
        //     foreach(var g in AllHives){
        //         alladdresses.Add(g.hiveAddress +","+ g.hiveCity +","+  g.hiveState +","+ g.hiveZip);
        //     }
        //     ViewBag.hiveaddresses= alladdresses;
        //     return Json(alladdresses);
        // }



        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
