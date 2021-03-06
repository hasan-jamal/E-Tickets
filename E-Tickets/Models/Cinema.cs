using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace E_Tickets.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Image Logo")]
        public string Logo { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        //RelationShip
        public List<Movie> Movies { get; set; }
    }
}
