using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Tickets.Controllers
{
    public class CinemasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
