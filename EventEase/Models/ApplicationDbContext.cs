using System.Collections;
using EventEase.Models;
using Microsoft.EntityFrameworkCore;


namespace EventEase.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Venues> Venues { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Events> Events { get; set; }
        public DbSet<EventType> EventTypes { get; set; }

        // (and others like Customers, Venues if needed)


    }
}
