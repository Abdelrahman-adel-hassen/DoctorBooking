using Appointment.Shared.DTO;
using Notification.Shared;

namespace Notification.API
{
    public sealed class NotificationsModuleApi : INotificationsModuleApi
    {
        public Task SendAsync(AppointmentDetails appointmentDetails)
        {
            // TODO: Implement an Notification sender
            Console.WriteLine($"Sending notification to {appointmentDetails.PatientName} for appointment with {appointmentDetails.DoctorName} at {appointmentDetails.ReservedAt}");
            return Task.CompletedTask;
        }
    }
}
