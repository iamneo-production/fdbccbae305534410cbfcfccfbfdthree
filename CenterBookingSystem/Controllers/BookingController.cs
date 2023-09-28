using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using CenterBookingSystem.Models;
using CenterBookingSystem.Data;
using CenterBookingSystem.Models;

namespace CenterBookingSystem.Controllers
{
    public class BookingController : Controller
    {     private readonly BookingDbContext _context;
          public BookingController(BookingDbContext context)
        {
            _context = context;
        }
          public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create(int spaceId,DateTime eventDate,TimeSpan timeSlot,string organizerID)
        {
            spaceId=1;
            eventDate=DateTime.Now;
            timeSlot=TimeSpan.Parse("10.30");
            organizerID="232";
            var data=new Booking{SpaceID=spaceId,EventDate=eventDate,TimeSlot=timeSlot,OrganizerID=organizerID};
            var result=_context.Bookings.Add(data);
            if(result == null)
             throw new EventBookingException("Space already booked.");
            return RedirectToAction("Confirmation");
        }
        public IActionResult Confirmation(int bookingID)
        {
            return View(bookingID);
        }
        // Write your BookingController here...
        // Index() - returns view
        // Create(int spaceId, DateTime eventDate, TimeSpan timeSlot, string organizerID) 
        //      - Handle EventBookingException "Space is not available for the selected date."
        //      - return RedirectTo "Confirmation" page with BookingID
        // Confirmation(int bookingId) - returns View(booking)
    }
}
