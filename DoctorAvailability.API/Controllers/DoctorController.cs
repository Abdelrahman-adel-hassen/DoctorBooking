namespace DoctorAvailability.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController(IDoctorService doctorservice) : ControllerBase
    {

        [HttpGet("GetAllSlots")]
        [SwaggerOperation(Summary = "Get All Slots", Description = "Retrieves a list of all slots of doctor in the system.")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult GetAllSlots(Guid doctorId)
        {
            return Ok(doctorservice.GetDoctorSlots(doctorId));
        }

        [HttpPost("NewDoctorSlot")]
        [SwaggerOperation(Summary = "Add New Slot", Description = "Add new Slot for a doctor")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult NewDoctorSlot([FromBody] IEnumerable<Slot> slots)
        {
            var result = doctorservice.AddDoctorSlot(slots);
            if (!result)
                return BadRequest();

            return Ok();
        }
    }
}
