using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using BEE.Models;

namespace BEE.Controllers
{
    public class HomeController : Controller
    {
        private BeeContext _context;
        public HomeController(BeeContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
<<<<<<< HEAD
=======
        }
        public IActionResult LoginUser()
        {
            return View("Register");
>>>>>>> fb7869f38d73aeb3faf578fb114d2ce928fb4899
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
