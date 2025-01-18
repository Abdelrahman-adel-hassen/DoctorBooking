
using DoctorAppointmentManagement.Core.InputPorts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DoctorAppointmentManagement.Shell.Controllers;
[Route("api/[controller]")]
[ApiController]
public class AppointmentController(IAppointmentServicePort appointmentService) : ControllerBase
{
    private readonly IAppointmentServicePort _appointmentService = appointmentService;

    [HttpGet("")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public IActionResult GetUpcomingAppointments()
    {
        return Ok(_appointmentService.GetUpcomingAppointments());
    }
    [HttpPut("cancel")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public IActionResult CancelAppointment([FromRoute] Guid appointmentId)
    {
        var result= _appointmentService.CancelAppointment(appointmentId);
        if(result)
            return Ok("Cancelled");
        return BadRequest();
    }

    [HttpPut("complete")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public IActionResult CompleteAppointment([FromRoute] Guid appointmentId)
    {
        var result = _appointmentService.CompleteAppointment(appointmentId);
        if(result)
            return Ok("Completed");
        return BadRequest();
    }
}
