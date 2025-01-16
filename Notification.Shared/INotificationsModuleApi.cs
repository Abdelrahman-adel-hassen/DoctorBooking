using DoctorBooking.Shared.Models;

namespace Notification.Shared;

public interface INotificationsModuleApi
{
    Task SendAsync(AppointmentNotification appointmentDetails);

}