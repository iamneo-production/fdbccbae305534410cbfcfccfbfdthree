using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CenterBookingSystem.Models
{
          public class EventSpace{
                public int SpaceID{get;set;}
                public string Name{get;set;}
                public int Capacity{get;set;}
                public bool Availability{get;set;}
                public ICollection< Booking> Bookings{get;set;}

        }
        // write your EventSpace class here...
}
