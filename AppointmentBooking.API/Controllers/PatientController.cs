namespace AppointmentBooking.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController(ISlotViewService slotViewService, IAppointmentBookService appointmentBookService) : ControllerBase
    {

        [HttpGet("GetAvailableSlots")]
        [SwaggerOperation(Summary = "Get Available Slots", Description = "Retrieves a list of all availableSlots in the system.")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult GetAvailableSlots(Guid doctorId)
        {
            return Ok(slotViewService.GetAvailableSlots(doctorId));
        }

        [HttpPost("BookAppointment")]
        [SwaggerOperation(Summary = "Book An Appointment", Description = "Book an appointment with specific doctor")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult BookAppointment(Guid patientId, Guid doctorId, Guid slotId)
        {
            var result = appointmentBookService.BookAppointment(patientId, doctorId, slotId);
            if (result is null)
                return BadRequest();

            return Ok(result);
        }
    }
}
