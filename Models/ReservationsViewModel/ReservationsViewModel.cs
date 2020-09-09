//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.ComponentModel.DataAnnotations;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Mvc.Rendering;


//namespace TennisClub.Models.ReservationsViewModel
//{
//    public class ReservationsViewModel
//    {
//        [Key]
//        [Display(Name = "Broj rezervacije:")]
//        public int ReservationID { get; set; }

//        [Required]
//        [StringLength(100)]
//        [Display(Name = "Naziv")]
//        public string Subject { get; set; }

//        [StringLength(100)]
//        [Display(Name = "Opis")]
//        public string Description { get; set; }

//        [Required(ErrorMessage = "Ovo polje je obavezno")]
//        [DisplayName("Datum i vreme početka")]
//        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm}")]
//        public DateTime StartDateReservation { get; set; }

//        [Required(ErrorMessage = "Ovo polje je obavezno")]
//        [DisplayName("Datum i vreme kraja")]
//        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm}")]
//        public DateTime EndDateReservation { get; set; }

//        [Display(Name = "Iznos:")]
//        public int Amount { get; set; }

//        [Required]
//        [Display(Name = "Teren:")]
//        public string Court { get; set; }

//        public static List<SelectListItem> Courts { set; get; }

//        //[Required(ErrorMessage = "Korisnik je obavezan")]
//        public string UserID { get; set; }


//        public ApplicationUser User { get; set; }
//    }
//}
