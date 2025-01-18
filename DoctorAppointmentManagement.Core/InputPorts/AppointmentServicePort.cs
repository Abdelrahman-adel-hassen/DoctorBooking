using DoctorBooking.Shared.Models;

namespace DoctorAppointmentManagement.Core.InputPorts;
public interface IAppointmentServicePort
{
    ICollection<Appointment> GetUpcomingAppointments();
    bool CancelAppointment(Guid appointmentId);
    bool CompleteAppointment(Guid appointmentId);
}
