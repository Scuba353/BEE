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
            return View( "AddHivePage" );
        }


        public IActionResult CreateHiveForm( HiveViewModel model )
        {
            if( ModelState.IsValid )
            {

                user CurrentUser = _context.users.Include( u => u.hives ).SingleOrDefault( u => u.userid == ( int )HttpContext.Session.GetInt32( "userid" ));


                hive NewestHive = new hive
                {
                    hiveAddress = model.hiveAddress,
                    hiveCity = model.hiveCity,
                    hiveState = model.hiveState,
                    hiveZip = model.hiveZip,
                    age = model.age,
                    status = model.status,
                    notes = model.notes,
                    userid = CurrentUser.userid
                };
                _context.hives.Add( NewestHive );
                _context.SaveChanges();

                NewestHive = _context.hives.SingleOrDefault( a => a.status == model.status );
                HttpContext.Session.SetInt32( "hiveid", NewestHive.hiveid );
                // return RedirectToAction( "ShowHiveDetails", new { id = HttpContext.Session.GetInt32( "hiveid" )});
                
                
                return RedirectToAction( "MyHivesDash" );
                
            }
            return View( "AddHivePage" );
        }

        public IActionResult MyHivesDash()
        {
            if( HttpContext.Session.GetInt32( "userid" ) == null )
            {
                return RedirectToAction( "AddHivePage", "Hive" );
            }
            user RetrievedUser = _context.users.SingleOrDefault( u => u.userid == ( int )
                                                HttpContext.Session.GetInt32( "userid" ));


            List<hive> AllMyHives = _context.hives
                                        .OrderByDescending( hi => hi.age )
                                        .Include( u => u.userid )
                                        //.ThenInclude( g => g.user )
                                        .ToList();

            ViewBag.RetrievedUser = HttpContext.Session.GetInt32( "userid" );

            return View( "MyHivesPage", AllMyHives );
        }








        public IActionResult HiveDetails( int id )
        {
            if( HttpContext.Session.GetInt32( "userid" ) == null )
            {
                return RedirectToAction( "Index", "Home" );
            }

            hive ThisHive = _context.hives
                                        .Include( r => r.user )
                                        .SingleOrDefault( w => w.hiveid == id );

            ViewBag.ThisHive = ThisHive;

            return View( "EditMyHivePage", ThisHive );
        }


        public IActionResult EditHiveForm( int id, HiveViewModel model )
        {
            hive RetrievedHive = _context.hives.SingleOrDefault( hi => hi.hiveid == id );

            RetrievedHive.hiveAddress = model.hiveAddress;
            RetrievedHive.hiveCity = model.hiveCity;
            RetrievedHive.hiveState = model.hiveState;
            RetrievedHive.hiveZip = model.hiveZip;
            RetrievedHive.age = model.age;
            RetrievedHive.status = model.status;
            RetrievedHive.notes = model.notes;

            _context.SaveChanges();
            return RedirectToAction( "MyHivesDash" );
        }


        public IActionResult DeleteHiveForm( int id )
        {
            hive x = _context.hives.SingleOrDefault( hi => hi.hiveid == id );
            _context.hives.Remove( x );
            _context.SaveChanges();
            return RedirectToAction( "MyHivesDash" );
        }
    


    }
}