using CarWise.Data;
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
        public IActionResult Index()
        {
            var instructors = _context.Cars.ToList();
            return View(instructors);
        }
    }
}