using CenterBookingSystem.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace CenterBookingSystem.Data
{
    public class BookingDbContext : DbContext
    {
        public BookingDbContext()
        {
        }  
        public BookingDbContext(DbContextOptions<BookingDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<EventSpace> EventSpaces { get; set; }
        public virtual DbSet<Booking> Bookings { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("User ID=sa;password=examlyMssql@123;server=localhost;Database=BookingDB;trusted_connection=false;Persist Security Info=False;Encrypt=False;");
            }
             }
        // Write your ApplicationDbContext here...
    }}
        // Write your BookingDbContext here...
    


