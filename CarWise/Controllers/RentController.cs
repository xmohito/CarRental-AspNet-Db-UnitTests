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
    public class RentController : Controller
    {

        private readonly AppDbContext db;

        public RentController(AppDbContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            var carData = db.Cars.ToList();
            return View(carData);

        }
        
        [HttpPost]
        public IActionResult Index(string name, string surname, DateTime birthdate, int phonenumber, string email, DateTime receiptdate, DateTime returndate, int car)
        {
            using (var contex = db.Database.BeginTransaction())
            {
                if (!string.IsNullOrWhiteSpace(name) && !string.IsNullOrWhiteSpace(surname) && phonenumber != 0 && !string.IsNullOrWhiteSpace(email))
                {
                    var insertedCustomer = new Customer
                    {
                        Name = name,
                        Surname = surname,
                        BirthDate = birthdate,
                        PhoneNumber = phonenumber,
                        Email = email
                    };
                    db.Customers.Add(insertedCustomer);
                    db.SaveChanges();
                    Console.WriteLine(car);
                    var insertedRent = new Rental
                    {
                        IdCar = car,
                        IdCustomer = insertedCustomer.Id,
                        ReceiptDate = receiptdate,
                        ReturnDate = receiptdate,
                        ToPay = 1,
                        Pay = false

                    };
                    db.Rentals.Add(insertedRent);
                    db.SaveChanges();
                    contex.Commit();
                    ViewData["Message"] = "Added";
                    return RedirectToAction("index", "Rent");
                }
                else
                {
                    ViewData["Message"] = "Incorrect data!";
                    return View();
                }


                return View();
                

            }
        }
    }
}
