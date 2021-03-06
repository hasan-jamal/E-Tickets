using E_Tickets.Data;
using E_Tickets.Data.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Tickets.Controllers
{
    public class MoviesController : Controller
    {
        public readonly AppDbContext _context;
        public MoviesController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var AllMovies = await _context.Movies.Include(n => n.Cinema).OrderBy(x => x.Name).ToListAsync();
            return View(AllMovies);
        }
       
        public IActionResult Details(int id)
        {
            return View();
        }
    }
}
