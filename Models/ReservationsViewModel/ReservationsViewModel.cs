using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TennisClub.Models.ReservationsViewModel
{
    public class ReservationsViewModel
    {
        [Key]
        [Display(Name = "Broj rezervacije:")]
        public int ReservationID { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Naziv")]
        public string Subject { get; set; }


        [StringLength(100)]
        [Display(Name = "Opis")]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Početak")]
        public DateTime Start { get; set; }

        
        [Display(Name = "Kraj")]
        public DateTime End { get; set; }

        [Display(Name = "Boja")]
        public string ThemeColor { get; set; }

        [Display(Name = "Rezerviši ceo dan")]
        public bool IsFullDay { get; set; }

        //[Required(ErrorMessage = "Korisnik je obavezan")]
        public string UserID { get; set; }


        public ApplicationUser User { get; set; }
    }
}
