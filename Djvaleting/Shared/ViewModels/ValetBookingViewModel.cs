using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Djvaleting.Shared.ViewModels
{
    public class ValetBookingViewModel
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Booking Date")]
        public DateTime BookingDate { get; set; }


        [Required]
        [Display(Name = "Flexibility")]
        public int Flexibility { get; set; }


        [Required]
        [Display(Name = "Vehicle Size")]
        public string VehicleSize { get; set; }


        [Required]
        [Display(Name = "Contact Number")]
        public string ContactNumber { get; set; }


        [Required]
        [Display(Name = "Email")]
        public string EmailAddress { get; set; }
    }
}
