using DoctorBooking.Shared.Models;

namespace AppointmentBooking.Shared.Interfaces;
public interface IAppointmentShared
{
    ICollection<Appointment> GetUpcomingAppointments();
    bool CancelAppointment(Guid appointmentId);
    bool CompleteAppointment(Guid appointmentId);
}
