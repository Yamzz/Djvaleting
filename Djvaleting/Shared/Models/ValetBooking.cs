using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace Djvaleting.Shared.Models
{
    [Table("ValetBooking", Schema = "valeting")]
    public class ValetBooking
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public DateTime BookingDate { get; set; }

        [Required]
        public int Flexibility { get; set; }

        [Required]
        public string VehicleSize { get; set; }

        [Required]
        public string ContactNumber { get; set; }

        [Required]
        public string EmailAddress { get; set; }
    }
}
