using E_Tickets.Data.Services;
using E_Tickets.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Tickets.Controllers
{
    public class ActorsController : Controller
    {
        public readonly IServicesRepostarycs _services;
        public ActorsController(IServicesRepostarycs services)
        {
            _services = services;
        }
        public async Task<IActionResult> Index()
        {
            var allActor = await _services.GetAllAsync();
            return View(allActor);
        }
        //Get Details
        public async Task<IActionResult> Details(int id)
        {
            var ActorId = await _services.GetIdAsync(id);
            if (ActorId == null) return View("NotFound");
            return View(ActorId);
        }

        //Get //Create Actors
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create([Bind("ProfilePictureUrl,FullName,Bio")]Actor actor)
        {
            if(!ModelState.IsValid)
            {
                return View(actor);
            }
             await _services.AddAsync(actor);
            return RedirectToAction(nameof(Index));
        }

        //Get //Edit Actors
        public async Task<IActionResult> Edit(int id)
        {
            var result = await _services.GetIdAsync(id);
            if (result == null) return View("NotFound");
            return View(result);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("id,FullName,ProfilePictureUrl,Bio")] Actor actor)
        {
            if (!ModelState.IsValid)
            {
                return View(actor);
            }
            await _services.UpdateAsync(id, actor);
            return RedirectToAction(nameof(Index));
        }

    }
}
