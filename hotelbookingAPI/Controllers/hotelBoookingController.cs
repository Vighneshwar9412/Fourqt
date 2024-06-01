using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using hotelbookingAPI.Models;
using hotelbookingAPI.Data;
namespace hotelbookingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class hotelBoookingController : ControllerBase
    {
        private readonly ApiContext _context;
        public hotelBoookingController(ApiContext context)
        {
            _context = context;
        }
        [HttpPost]
        public JsonResult CreateEdit(HotelBooking booking)
        {
            if (booking.Id == 0)
            {
                _context.Bookings.Add(booking);
            }
            else {

                if (bookinginDb == null)
                { 
                    return new JsonResult(NotFound());
                }
                

                    bookinginDb = booking;
                
            }

            _context.SaveChanges();
            return new JsonResult(Ok(booking));
        }  
    }
}
