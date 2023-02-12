using CarWise.Data;
using CarWise.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarWise.Controllers;

namespace CarWise.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {

            User _user = new User();

            return View(User);
        }


        [HttpPost]
        public IActionResult Index(User _user)
        {
            AppDbContext _appDBContex = new AppDbContext();
            //var status = _appDBContex.Users.Where(c => c.Username == username. )


            return View(User);
        }
    }
}
//using (DbConn db = new DbConn())
//{
//    int userChecker = db.users.Where(c => c.UserName == txtUsername.Text && c.Pass == txtPassword.Password).Count();
//    if (userChecker == 1)
//    {
//        Panel dashboard = new Panel();
//        dashboard.Show();
//    }
//    else
//    {
//        MessageBox.Show("Nazwa użytkownika lub hasło została wprowadzona błędnie.");
//    }