using Appointment.Shared.DTO;
using AppointmentBooking.Domain.IRepositories;
using Notification.Shared;

namespace AppointmentBooking.Application.Services;
public class AppointmentBookService(IPatientRepo patientRepo, INotificationsModuleApi notification)
{
    public AppointmentDetails BookAppointment(Guid patientId, Guid doctorId, Guid slotId)
    {
        var appointmentDetails = patientRepo.BookAppointment(patientId, doctorId, slotId);
        notification.SendAsync(appointmentDetails);
        return appointmentDetails;
    }
}
