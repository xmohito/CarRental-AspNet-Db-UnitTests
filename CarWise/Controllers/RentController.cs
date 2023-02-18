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
using System.Text.RegularExpressions;
using System.Net.Mail;

namespace CarWise.Controllers
{
    public class RentController : Controller
    {

        private readonly AppDbContext db;

        public RentController(AppDbContext context)
        {
            db = context;
        }
        public IActionResult Index(string Message)
        {
            ViewData["Message"] = Message;
            var carData = db.Cars.ToList();
            return View(carData);

        }

        public bool IsAtLeast18YearsOld(DateTime birthdate)
        {
            int age = DateTime.Today.Year - birthdate.Year;
            if (birthdate > DateTime.Today.AddYears(-age))
            {
                age--;
            }
            return age >= 18;
        }

        public bool IsValidPhoneNumber(string phonenumberString)
        {
            int number;
            bool isInteger = int.TryParse(phonenumberString, out number);

            bool has9Digits = phonenumberString.Length == 9;

            return isInteger && has9Digits;
        }

        public bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                return false;
            }

            string pattern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            bool isMatch = Regex.IsMatch(email, pattern);

            return isMatch;
        }

        public void sendMail(string name, DateTime receiptdate, DateTime returndate, int carPrice, string email)
        {
            string body = "<h1>Witaj, " + name + "<br/></h1>";
            body += "Dziękujemy za dokonanie rezerwacji.<br/><br/>";
            body += "Data zameldowania: " + receiptdate + "<br/>";
            body += "Data wymeldowania: " + returndate + "<br/><br/>";
            body += "Da zapłaty: " + carPrice + " zł<br/>";

            try
            {
                using (MailMessage mail = new MailMessage())
                {
                    mail.From = new MailAddress("vip.apartaments@interia.pl", "CarWise");
                    mail.To.Add(email);
                    mail.Subject = "Potwierdzenie dokonania rezerwacji";
                    mail.Body = body;
                    mail.IsBodyHtml = true;

                    using (SmtpClient smtp = new SmtpClient("poczta.interia.pl", 587))
                    {
                        smtp.Credentials = new System.Net.NetworkCredential("vip.apartaments@interia.pl", "vipapartaments123");
                        smtp.EnableSsl = true;
                        smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                        smtp.Send(mail);
                    }
                }
            }
            catch
            {

            }

        }


        public int CalculateRentalDays(DateTime rentalDate, DateTime returnDate)
        {
            TimeSpan timeBetween = returnDate - rentalDate;

            int rentalDays = timeBetween.Days;

            return rentalDays;
        }


        [HttpPost]
        public IActionResult Index(string name, string surname, DateTime birthdate, int phonenumber, string email, DateTime receiptdate, DateTime returndate, int car)
        {

            using (var contex = db.Database.BeginTransaction())
            {
                if (!string.IsNullOrWhiteSpace(name) && !string.IsNullOrWhiteSpace(surname) && !string.IsNullOrWhiteSpace(email) && birthdate != DateTime.MinValue
                    && receiptdate != DateTime.MinValue && returndate != DateTime.MinValue && car != 0)
                {
                    string phonenumberString = phonenumber.ToString();
                    if (IsValidPhoneNumber(phonenumberString))
                    {
                        if (IsValidEmail(email)){
                            if (IsAtLeast18YearsOld(birthdate))
                            {
                                if(receiptdate == DateTime.MinValue || returndate == DateTime.MinValue || receiptdate > returndate || receiptdate < DateTime.Today)
                                {
                                    return RedirectToAction("index", "Rent", new { Message = "Enter a valid rental date range" });
                                }
                                else
                                {
                                    int carPrice = 0;
                                    if(car == 1)
                                    {
                                        carPrice = 650;
                                    }
                                    else if (car == 2)
                                    {
                                        carPrice = 300;
                                    }
                                    else if (car == 3)
                                    {
                                        carPrice = 600;
                                    }
                                    else if (car == 4)
                                    {
                                        carPrice = 700;
                                    }
                                    else if (car == 5)
                                    {
                                        carPrice = 500;
                                    }
                                    else if (car == 6)
                                    {
                                        carPrice = 340;
                                    }

                                    TimeSpan timeSpan = returndate - receiptdate;
                                    int totalDays = timeSpan.Days;
                                    int totalPrice = carPrice * totalDays;
                                     

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
                                        ReturnDate = returndate,
                                        ToPay = totalPrice,
                                        Pay = false

                                    };
                                    db.Rentals.Add(insertedRent);
                                    db.SaveChanges();
                                    contex.Commit();
                                    return RedirectToAction("index", "Rent", new { Message = $"Succesful! "+name+", you have to pay " +totalPrice+ " zł for your rental. Payment will be made upon receipt of the car." });
                                }
                            }
                            else
                            {
                                return RedirectToAction("index", "Rent", new { Message = "You must be 18 years old to rent a car" });
                            }
                        }
                        else
                        {
                            return RedirectToAction("index", "Rent", new { Message = "Enter vaild email" });
                        }

                    }
                    else
                    {
                        return RedirectToAction("index", "Rent", new { Message = "Enter correct type of phone number" });
                    }
                }
                else
                {
                    return RedirectToAction("index", "Rent", new {Message = "Pick the car and enter all informations" });
                }
                

            }
        }
    }
}
