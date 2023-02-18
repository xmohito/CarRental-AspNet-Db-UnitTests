using CarWise.Data;
using CarWise.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarWise.Controllers
{
    public class PanelController : Controller
    {
        private readonly AppDbContext _context;
        public PanelController(AppDbContext context)
        {
            _context = context;
        }


        public class dataInDataGrid
        {
            public int Id { get; set; }
            public int? IdCar { get; set; }
            public string Name { get; set; }
            public string Surname { get; set; }
            public DateTime ReceiptDate { get; set; }
            public DateTime ReturnDate { get; set; }
            public int ToPay { get; set; }
            public bool Pay { get; set; }

        }



        // GET: Rentals
        public IActionResult Index()
        {
            var username = HttpContext.Session.GetString("Session_Username");
            Console.WriteLine(username);

            if (!string.IsNullOrEmpty(username))
            {
                var gridData = (from Rental in _context.Rentals
                                join Customer in _context.Customers
                                on Rental.IdCustomer equals Customer.Id
                                select new
                                {
                                    Rental.Id,
                                    Rental.IdCar,
                                    Customer.Name,
                                    Customer.Surname,
                                    Rental.ReceiptDate,
                                    Rental.ReturnDate,
                                    Rental.ToPay,
                                    Rental.Pay
                                }).ToList();

                List<dataInDataGrid> datas = new List<dataInDataGrid>();
                foreach (var rent in gridData)
                {
                    datas.Add(new dataInDataGrid
                    {
                        Id = rent.Id,
                        IdCar = rent.IdCar,
                        Name = rent.Name,
                        Surname = rent.Surname,
                        ReceiptDate = rent.ReceiptDate,
                        ReturnDate = rent.ReturnDate,
                        ToPay = rent.ToPay,
                        Pay = rent.Pay
                    });
                }
                return View(datas);
            }
            else
            {
                return RedirectToAction("Index", "Login", new { Message = "Nie masz uprawnień!" });
            }
        }

        // GET: Rentals/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Rentals/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,IdCustomer,IdCar,ReceiptDate,ReturnDate,ToPay,Pay")] Rental rental)
        {
            if (ModelState.IsValid)
            {
                _context.Add(rental);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(rental);
        }

        // GET: Rentals/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rental = await _context.Rentals.FindAsync(id);
            if (rental == null)
            {
                return NotFound();
            }
            return View(rental);
        }

        // POST: Rentals/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,IdCustomer,IdCar,ReceiptDate,ReturnDate,ToPay,Pay")] Rental rental)
        {
            if (id != rental.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(rental);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RentalExists(rental.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(rental);
        }

        // GET: Rentals/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rental = await _context.Rentals
                .FirstOrDefaultAsync(m => m.Id == id);
            if (rental == null)
            {
                return NotFound();
            }

            return View(rental);
        }

        // POST: Rentals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var rental = await _context.Rentals.FindAsync(id);
            _context.Rentals.Remove(rental);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RentalExists(int id)
        {
            return _context.Rentals.Any(e => e.Id == id);
        }
    }
}