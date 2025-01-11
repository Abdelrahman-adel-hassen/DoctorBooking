using AppointmentBooking.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace AppointmentBooking.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController(SlotViewService slotViewService, AppointmentBookService appointmentBookService) : ControllerBase
    {
        private readonly SlotViewService _slotViewService = slotViewService;
        private readonly AppointmentBookService _appointmentBookService = appointmentBookService;

        [HttpGet("GetAvailableSlots")]
        public IActionResult GetAvailableSlots()
        {
            return Ok(_slotViewService.GetAvailableSlots());
        }

        [HttpPost("BookAppointment")]
        public IActionResult BookAppointment(Guid patientId, Guid doctorId, Guid slotId)
        {
            var result = _appointmentBookService.BookAppointment(patientId, doctorId, slotId);
            if (result is null)
                return BadRequest();

            return Ok(result);
        }
    }
}
