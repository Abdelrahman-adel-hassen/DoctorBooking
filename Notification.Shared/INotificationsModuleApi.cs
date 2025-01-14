using DoctorBooking.Shared.Modules;

namespace Notification.Shared;

public interface INotificationsModuleApi
{
    Task SendAsync(AppointmentNotification appointmentDetails);

}