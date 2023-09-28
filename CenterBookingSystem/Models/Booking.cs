using System;
using System.Collections.Generic;

namespace CenterBookingSystem.Models
{ public class Booking{
        public int BookingID{get;set;}
        public int SpaceID{get;set;}
        public int OrgaizerID{get;set;}
        public DateTime EventDate{get;set;}
        public TimeSpan TimeSlot{get;set;}

    }
    // write your Booking class here...
}
