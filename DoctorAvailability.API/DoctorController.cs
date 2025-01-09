using DoctorAvailability.BLL.Services;
using DoctorAvailability.DAL.Models;
using Microsoft.AspNetCore.Mvc;

namespace DoctorAvailability.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController(DoctorService doctorservice) : ControllerBase
    {
        private readonly DoctorService _doctorService = doctorservice;

        [HttpGet("")]
        public IActionResult GetAllSlots([FromRoute] Guid doctorId)
        { 
            return Ok(_doctorService.GetDoctorSlots(doctorId));
        }

        [HttpPost("")]
        public IActionResult NewDoctorSlot([FromBody] IEnumerable<Slot> slots)
        {
            var result = _doctorService.AddDoctorSlot(slots);
            if (!result)
                return BadRequest();

            return Ok();
        }
    }
}
