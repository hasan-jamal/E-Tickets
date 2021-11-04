using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Tickets.Models
{
    public class Actor_Movie
    {
        public int MovieId { get; set; }
        public Movie Movies { get; set; }
        public int ActorId { get; set; }
        public Actor Actors { get; set; }
    }
}
