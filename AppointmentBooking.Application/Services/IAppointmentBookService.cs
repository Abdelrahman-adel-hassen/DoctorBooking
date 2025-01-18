namespace AppointmentBooking.Application.Services
{
    public interface IAppointmentBookService
    {
        AppointmentDetails BookAppointment(Guid patientId, Guid doctorId, Guid slotId);
    }
}
