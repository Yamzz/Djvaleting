using Djvaleting.Server.Core.Services;
using Djvaleting.Shared.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Djvaleting.Server.Controllers
{
    [ApiController]
    [Route("api/valetbooking")]
    public class ValetBookingController : ControllerBase
    {
        private readonly IValetBookingService _valetBookingService;
        public ValetBookingController(IValetBookingService valetBookingService)
        {
            _valetBookingService = valetBookingService;
        }

        // GET: api/valetbookings
        [HttpGet]
        public IActionResult Get()
        {
            var employees = _valetBookingService.GetAllValetBookings();
            return Ok(employees);
        }


        // GET: api/valetbooking/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(int id)
        {
            var booking = _valetBookingService.GetValetBooking(id);
            if (booking == null)
            {
                return NotFound("The booking record couldn't be found.");
            }
            return Ok(booking);
        }

        // POST: api/valetbooking
        [HttpPost]
        public IActionResult Post([FromBody] ValetBookingViewModel valetBookingViewModel)
        {
            if (valetBookingViewModel == null)
            {
                return BadRequest("Booking is empty");
            }

            _valetBookingService.AddValetBooking(valetBookingViewModel);

            return Ok(valetBookingViewModel.Id);
        }


        // PUT: api/valetbooking/5
        [HttpPut("{id}")]
        public IActionResult Put(long id, [FromBody] ValetBookingViewModel valetBookingViewModel)
        {
            if (valetBookingViewModel == null)
            {
                return BadRequest("Booking is null.");
            }

            _valetBookingService.UpdateValetBooking(valetBookingViewModel);

            return Ok(valetBookingViewModel.Id);
        }

        // DELETE: api/valetbooking/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var booking = _valetBookingService.GetValetBooking(id);
            if (booking == null)
            {
                return NotFound("The booking record couldn't be found.");
            }
            _valetBookingService.DeleteValetBooking(booking.Id);
            return Ok();
        }
    }
}
