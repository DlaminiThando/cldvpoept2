using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
 using EventEase.Models;

namespace EventEase.Models
{

   

    public class Events
    {
        [Key]
        public int EventID { get; set; }
        public string EventName { get; set; }
        public DateTime EventDate { get; set; }

        [ForeignKey("VenueID")]
        public int VenueID { get; set; }
        public string? EventType { get; set; }
        public string? Description { get; set; }
        public decimal TicketPrice { get; set; }

        public Venues? Venue { get; set; }
        public List<Booking> Bookings { get; set; } = new();
    }
}
