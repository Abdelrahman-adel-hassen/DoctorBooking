using DoctorBooking.Shared.Models;
using Notification.Shared;

namespace Notification.API
{
    public sealed class NotificationsModuleApi : INotificationsModuleApi
    {
        public Task SendAsync(AppointmentDetails appointment)
        {
            // TODO: Implement an Notification sender
            Console.WriteLine($"Sending notification to {appointment.PatientName} for appointment with {appointment.DoctorName} at {appointment.ReservedAt}");
            return Task.CompletedTask;
        }
    }
}
