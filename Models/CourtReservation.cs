using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TennisClub.Models
{
    public class CourtReservation
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

        [Required]
        [Display(Name = "Kraj")]
        public DateTime End { get; set; }

        [Display(Name = "Iznos:")]
        public int Amount { get; set; }

        [Required]
        [Display(Name = "Teren:")]
        public int Court { get; set; }

        public static List<SelectListItem> Courts { set; get; }

        //[Required(ErrorMessage = "Korisnik je obavezan")]
        public string UserID { get; set; }


        public ApplicationUser User { get; set; }
    }
}

