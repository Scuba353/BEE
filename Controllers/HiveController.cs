using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BEE.Models;

namespace BEE.Controllers
{
    public class HiveController : Controller
    {
        private BeeContext _context;
        public HiveController( BeeContext context )
        {
            _context = context;
        }

        public IActionResult AddNewHivePage(  )
        {
            return View( "test", "Hive" );
        }


        // public IActionResult CreateHiveForm( HiveViewModel model )
        // {
        //     if( ModelState.IsValid )
        //     {
        //         user CurrentUser = _context.users.Include( u => u.hives ).SingleOrDefault( u => u.userid == ( int )HttpContext.Session.GetInt32( "userid" ));
            
        //         hive NewHive = new hive
        //         {
        //             hiveAddress = model.hiveAddress,
        //             hiveCity = model.hiveCity,
        //             hiveState = model.hiveState,
        //             hiveZip = model.hiveZip,
        //             age = model.age,
        //             status = model.status,
        //             notes = model.notes
        //         };
        //         _context.hives.Add( NewHive );
        //         _context.SaveChanges();

        //         NewHive = _context.hives.SingleOrDefault( a => a.status == model.status );
        //         HttpContext.Session.SetInt32( "hiveid", NewHive.hiveid );
        //         return RedirectToAction( "ShowHiveDetails", new { id = HttpContext.Session.GetInt32( "hiveid" )});
            
        //     }
        //     return View( "AddHivePage", "Hive" );
        // }
    


    }
}