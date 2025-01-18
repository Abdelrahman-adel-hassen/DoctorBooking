namespace AppointmentBooking.Application.Services;
public class AppointmentBookService(IPatientRepo patientRepo, IDoctorShared doctorRepo, INotificationsModuleApi notification) : IAppointmentBookService
{
    public AppointmentDetails BookAppointment(Guid patientId, Guid doctorId, Guid slotId)
    {
        var appointmentDetails = patientRepo.BookAppointment(patientId, doctorId, slotId);

        if (appointmentDetails is not null)
        {
            notification.SendAsync(appointmentDetails);
            doctorRepo.ReserveSlot(slotId);
        }
        return appointmentDetails;
    }
}
