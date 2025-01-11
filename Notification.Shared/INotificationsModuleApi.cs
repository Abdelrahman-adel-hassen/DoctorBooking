
using Appointment.Shared.DTO;

namespace Notification.Shared;

public interface INotificationsModuleApi
{
    Task SendAsync(AppointmentDetails appointmentDetails);

}