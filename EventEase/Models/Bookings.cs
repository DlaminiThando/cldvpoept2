using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using EventEase.Models;
using Humanizer.Localisation;

namespace EventEase.Models
{
    public class Booking
    {
        [Key]
        public int BookingID { get; set; }

        [Required]
        [Display(Name = "Event")]
        public int EventID { get; set; }

        [Required]
        [Display(Name = "Venue")]
        public int VenueID { get; set; }

        [Required]
        [Display(Name = "Booking Date")]
        [DataType(DataType.Date)]
        public DateTime BookingDate { get; set; }


        [Required]
        [Display(Name = "Seats Booked")]
        [Range(1, 1000, ErrorMessage = "Please book at least 1 seat.")]
        public int SeatsBooked { get; set; }

        [Required]
        [Display(Name = "Booking Status")]
        public string BookingStatus { get; set; }

        // Optional - if you are collecting customer info in a text field
        [Display(Name = "Customer ID (Optional)")]


        // Navigation properties
        public virtual Events? Event { get; set; }
        public virtual Venues? Venue { get; set; }
    }
}
