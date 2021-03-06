using E_Tickets.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Tickets.Data.Services
{
    public class ServicesRepostarycs : IServicesRepostarycs
    {
        public readonly AppDbContext _context;
        public ServicesRepostarycs(AppDbContext context)
        {
            _context = context;
        }
        
        public async Task AddAsync(Actor actor)
        {
             await _context.Actors.AddAsync(actor);
             await _context.SaveChangesAsync();
           
        }

        public void Delete(int id)
        {
         
                    
        }

        public async Task<IEnumerable<Actor>> GetAllAsync()
        {
            var AllActors = await _context.Actors.ToListAsync();
            return AllActors;
        }

        public async Task<Actor> GetIdAsync(int id)
        {
            var result = await _context.Actors.FirstOrDefaultAsync(n => n.Id == id);
            return result;
        }

        public async Task<Actor> UpdateAsync(int id, Actor newActor)
        {
              newActor.Id = id;
             _context.Actors.Update(newActor);
            await _context.SaveChangesAsync();
            return newActor;
        }
    }
}
