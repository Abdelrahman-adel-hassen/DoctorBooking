using DoctorAvailability.BLL.Services;
using DoctorBooking.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace DoctorAvailability.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController(DoctorService doctorservice) : ControllerBase
    {
        private readonly DoctorService _doctorService = doctorservice;

        [HttpGet("GetAllSlots")]
        public IActionResult GetAllSlots(Guid doctorId)
        {
            return Ok(_doctorService.GetDoctorSlots(doctorId));
        }

        [HttpPost("NewDoctorSlot")]
        public IActionResult NewDoctorSlot([FromBody] IEnumerable<Slot> slots)
        {
            var result = _doctorService.AddDoctorSlot(slots);
            if (!result)
                return BadRequest();

            return Ok();
        }
    }
}
