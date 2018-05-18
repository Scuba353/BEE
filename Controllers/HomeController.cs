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
        }
        public IActionResult LoginUser()
        {
            return View("Register");
        }
        public IActionResult AddUserForm(NewUserViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (_context.users.SingleOrDefault(u => u.email == model.email) != null)
                {
                    TempData["Error"] = "☝🏻 Email is already in use, please try another email address";
                    
                    return RedirectToAction("Register");
                }

                PasswordHasher<NewUserViewModel> Hasher = new PasswordHasher<NewUserViewModel>();
                model.password = Hasher.HashPassword(model, model.password);
                user AddUser = new user
                {
                    firstName = model.firstName,
                    lastName = model.lastName,
                    stAddress = model.stAddress,
                    city = model.city,
                    state = model.state,
                    zip = model.zip,
                    email = model.email,
                    userType = model.userType,
                    password = model.password
                    
                };
                _context.users.Add(AddUser);
                _context.SaveChanges();
                AddUser = _context.users.SingleOrDefault(u => u.email == AddUser.email);
                HttpContext.Session.SetInt32("userid", AddUser.userid);
              
                return RedirectToAction("Dashboard", "Home");
            }
            return View("Register");
        }
        public IActionResult Dashboard(int id)
        {
            if (HttpContext.Session.GetInt32("userid") == null)
            {
                return RedirectToAction("LoginUser", "Home");
            }
            user LoggedUser = _context.users.SingleOrDefault(au => au.userid == (int)HttpContext.Session.GetInt32("userid"));
            
            ViewBag.LoggedUser = LoggedUser;
            return View("IndexTwo");
        }
        public IActionResult LoginUserForm(RegisteredUserViewModel model)
        {
            if (ModelState.IsValid)
            {
                user RegisteredUser = _context.users.SingleOrDefault(ul => ul.email == model.email);
                if (RegisteredUser != null)
                {
                    if (model.email != null && model.password != null)
                    {
                        var Hasher = new PasswordHasher<RegisteredUserViewModel>();
                        if (0 != Hasher.VerifyHashedPassword(model, RegisteredUser.password, model.password))
                        {
                            HttpContext.Session.SetInt32("userid", RegisteredUser.userid);
                            return RedirectToAction("Dashboard", "Home");
                        }
                    }
                }

            }
            TempData["Error"] = "☝🏻 Please verify that you've correctly entered your email and resubmit";
            return View("Register");

        }
        public IActionResult LogOut()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
