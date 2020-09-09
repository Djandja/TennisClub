using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TennisClub.Models.TurnirsViewModel
{
    public class Turnirs
    {
        [Key]
        public int TurnirID { get; set; }

        [Required(ErrorMessage ="Ovo polje je obavezno")]
        [StringLength(50)]
        [DisplayName("Naziv turnira")]
        public string TurnirsTitle { get; set; }

        [Required(ErrorMessage = "Ovo polje je obavezno")]
        [DisplayName("Datum i vreme početka")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm}")]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = "Ovo polje je obavezno")]
        [DisplayName("Datum i vreme kraja")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm}")]
        public DateTime EndDate { get; set; }

        [Required(ErrorMessage = "Ovo polje je obavezno")]
        [DisplayName("Maksimalni broj učesnika")]
        public int NumberOfParticipants { get; set; }

        
        [DisplayName("Broj prijavljenih učesnika")]
        public int NumberOfRegistered { get; set; }

        public string UserID { get; set; }


        public ApplicationUser User { get; set; }
    }
}
