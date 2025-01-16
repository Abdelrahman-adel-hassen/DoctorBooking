using DoctorAppointmentManagement.Core.InputPorts;
using DoctorAppointmentManagement.Core.OutPorts;
using DoctorBooking.Shared.Models;


namespace DoctorAppointmentManagement.Core.Services;
public class AppointmentService(IAppointmentRepo appointmentRepo) : AppointmentServicePort
{
    private readonly IAppointmentRepo _appointmentRepo = appointmentRepo;

    public bool CancelAppointment(Guid appointmentId)
    {
        var result = _appointmentRepo.CancelAppointment(appointmentId);
        return result;
    }

    public bool CompleteAppointment(Guid appointmentId)
    {
        var result = _appointmentRepo.CompleteAppointment(appointmentId);
        return result;
    }

    public ICollection<Appointment> GetUpcomingAppointments()
    {
        return _appointmentRepo.GetUpcomingAppointments();       
    }
}
