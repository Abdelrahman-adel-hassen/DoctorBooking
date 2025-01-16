using DoctorBooking.Shared.Models;

namespace DoctorAppointmentManagement.Core.OutPorts;
public interface IAppointmentRepo
{
    ICollection<Appointment> GetUpcomingAppointments();
    bool CancelAppointment(Guid appointmentId);
    bool CompleteAppointment(Guid appointmentId);
}
