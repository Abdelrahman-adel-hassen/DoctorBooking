namespace AppointmentBooking.Application.Services
{
    public interface IAppointmentBookService
    {
        AppointmentNotification BookAppointment(Guid patientId, Guid doctorId, Guid slotId);
    }
}
