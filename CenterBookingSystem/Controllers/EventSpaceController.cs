using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using CenterBookingSystem.Models;
using CenterBookingSystem.Data;

namespace CenterBookingSystem.Controllers
{
    public class EventSpaceController : Controller
    {        
          public IActionResult AvailableSpaces()
        {
            return View();
        }
        // Write your EventSpaceController here...
        // AvailableSpaces() - returns View(availableSpaces)
        //                   - Display available event spaces
    }
}
