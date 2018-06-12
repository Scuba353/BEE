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
    public class PermissionController : Controller
    {
        private BeeContext _context;
        public PermissionController( BeeContext context )
        {
            _context = context;
        }

        public IActionResult GivePermissionPage(  )
        {
            return View( "AddPermPage" );
        }


        public IActionResult CreatePermissionForm( PermissionViewModel model )
        {
            if( ModelState.IsValid )
            {
                user CurrentUser = _context.users.Include( u => u.permissions ).SingleOrDefault( u => u.userid == ( int )HttpContext.Session.GetInt32( "userid" ));

                permission NewPerm = new permission
                {
                    landAmt = model.landAmt,
                    allergies = model.allergies,
                    accessInfo = model.accessInfo,
                    accessTime = model.accessTime,
                    userid = CurrentUser.userid
                };
                _context.permissions.Add( NewPerm );
                _context.SaveChanges();

                NewPerm = _context.permissions.SingleOrDefault( p => p.permissionid == NewPerm.permissionid );
                HttpContext.Session.SetInt32( "permissionid", NewPerm.permissionid );

                return RedirectToAction( "PermissionDash" );//FOR TESTING DB, Should RedirectToAction to a DASH

            }
            return View( "AddPermPage" );
        }

        // *MI - not sure we need this feature, wasn't in the original plan
        //however I thought it might be nice––but I'm now running into MySQL
        //issues and cannot figure it out. Commented out for now.
        // public IActionResult EditPerm (int id, permission model)
        // {
        //     Console.WriteLine(id);
        //     permission OnePermission = _context.permissions.SingleOrDefault(p => p.permissionid == id);

        //     OnePermission.landAmt = model.landAmt;
        //     OnePermission.allergies = model.allergies;
        //     OnePermission.accessInfo = model.accessInfo;
        //     OnePermission.accessTime = model.accessTime;
        //     OnePermission.userid = model.userid;
            

        //     _context.SaveChanges();
        //     return RedirectToAction("PermissionDash");
        // }
        public IActionResult PermissionDash()
        {
            if (HttpContext.Session.GetInt32("userid") == null)
            {
                return RedirectToAction("CreatePermissionForm", "Permission");
            }
            user RetrievedUser = _context.users.SingleOrDefault(u => u.userid == (int)HttpContext.Session.GetInt32("userid"));


            List<permission> AllPermissions = _context.permissions
                                        .OrderByDescending( p => p.landAmt )
                                        // .Include(u => u.userid)
                                        // .Where(w => w.userid == RetrievedUser.userid)
                                        //.ThenInclude( g => g.user )
                                        .ToList();

            ViewBag.RetrievedUser = RetrievedUser;

            return View("PermDash", AllPermissions);
        }
        public IActionResult DeletePermFromList(int id)
        {
            permission claimed = _context.permissions.SingleOrDefault(p => p.permissionid == id);
            _context.permissions.Remove(claimed);
            _context.SaveChanges();
            return RedirectToAction("PermissionDash");
        }


    }
}