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

        // POST: api/Employee
        [HttpPost]
        public IActionResult Post([FromBody] ValetBookingViewModel valetBookingViewModel)
        {
            if (valetBookingViewModel == null)
            {
                return BadRequest("Booking is empty");
            }

            _valetBookingService.AddValetBooking(valetBookingViewModel);

            return null;
            //return CreatedAtRoute(
            //      "Get",
            //      new { Id = employee.EmployeeId },
            //      employee);
        }
    }

}
