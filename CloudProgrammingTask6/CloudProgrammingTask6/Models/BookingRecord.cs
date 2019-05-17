using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CloudProgrammingTask6.Models
{
    public class BookingRecord
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2)]
        public String FirstName { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2)]
        public String LastName { get; set; }

        [Required]
        [Range(0, 120)]
        public int Age { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2)]
        public String Gender { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2)]
        public String Departure { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2)]
        public String Arrival { get; set; }

        [Required]
        public DateTime DepartureTime { get; set; }

        [Required]
        public DateTime ArrivalTime { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2)]
        public String FlightNumber { get; set; }

        [Required]
        [Range(0, 100000)]
        public Double Price { get; set; }
        public String FareClass { get; set; }
        public String PromoCode { get; set; }
        public String State { get; set; }
        public String Note { get; set; }

    }

    public class ContactDBContext : DbContext
    {
        public DbSet<BookingRecord> Bookings { get; set; }
    }
}