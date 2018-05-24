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

                return View( "AddPermPage" );//FOR TESTING DB, Should RedirectToAction to a DASH

            }
            return View( "AddPermPage" );
        }


    }
}