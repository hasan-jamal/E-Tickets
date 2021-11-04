using E_Tickets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Tickets.Data.Services
{
   public interface IServicesRepostarycs
    {
        Task<IEnumerable<Actor>> GetAllAsync();
        Task<Actor> GetIdAsync(int id);
        Task AddAsync(Actor actor);
        Task<Actor> UpdateAsync(int id, Actor newActor);
        void Delete(int id);
    }
}
