using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace E_Tickets.Models
{
    public class Actor
    {

        [Key]
        public int Id { get; set; }
        [Display(Name = "Profile Picture Url")]
        [Required(ErrorMessage = "Profile Picture is Required")]
        public string ProfilePictureUrl { get; set; }
        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "Full Name is Required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Full Name must be between 3 and 50 char ")]
        public string FullName { get; set; }
        [Display(Name = "Bio")]
        [Required]
        public string Bio { get; set; }
        //RelationShip
        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}
