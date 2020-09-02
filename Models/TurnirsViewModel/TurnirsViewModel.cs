using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TennisClub.Models.TurnirsViewModel
{
    public class TurnirsViewModel
    {
        [Key]
        public int TurnirID { get; set; }

        [Required]
        [StringLength(50)]
        public string TurnirsTitle { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        [Required]
        public int NumberOfParticipants { get; set; }

        public string UserID { get; set; }
    }
}
