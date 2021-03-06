﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace TennisClub.Models
{
    public class Reservations
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
        [Display(Name = "Datum rezervacije:")]
        //[DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime StartDateReservation { get; set; }


        [Display(Name = "Iznos:")]
        public int Amount { get; set; }

        [Required]
        [Display(Name = "Teren:")]
        public string Court { get; set; }

        public static List<SelectListItem> Courts { set; get; }

        [Required]
        [Display(Name = "Vreme od:")]
        public string StartTime { get; set; }

        public static List<SelectListItem> StartTimes { set; get; }


        [Required]
        [Display(Name = "Vreme do:")]
        public string EndTime { get; set; }

        public static List<SelectListItem> EndTimes { set; get; }


        //[Required(ErrorMessage = "Korisnik je obavezan")]
        public string UserID { get; set; }


        public ApplicationUser User { get; set; }
    }
}
