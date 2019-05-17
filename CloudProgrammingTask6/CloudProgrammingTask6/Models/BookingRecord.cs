using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CloudProgrammingTask6.Models
{
    public class BookingRecord
    {
        public int ID { get; set; }

        public String FirstName { get; set; }
        public String LastName { get; set; }
        public int Age { get; set; }
        public String Gender { get; set; }
        public String Departure { get; set; }
        public String Arrival { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
        public String FlightNumber { get; set; }
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