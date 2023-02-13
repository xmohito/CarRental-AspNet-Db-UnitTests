using CarWise.Data;
using CarWise.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarWise.Controllers;
using Microsoft.AspNetCore.Http;
using System.Security.Cryptography;

namespace CarWise.Controllers
{
    public class LoginController : Controller
    {

        private readonly AppDbContext db;

        public LoginController(AppDbContext context)
        {
            db = context;
        }

        public IActionResult Index(string Message)
        {
            ViewData["Message"] = Message;
            return View();
        }

        [HttpPost]
        public IActionResult Index(string username, string password)
        {
            using (var contex = db.Database.BeginTransaction())
            {
                int userChecker = db.Users.Where(c => c.Username == username && c.Password == password).Count();
                if (userChecker == 1)
                {
                    return RedirectToAction("index", "Panel");
                }
                else
                {

                    ViewData["Message"] = "Incorrect username or password";
                    return View();
                }
                
            }
        }
    }

}