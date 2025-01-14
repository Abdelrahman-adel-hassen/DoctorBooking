namespace AppointmentBooking.Domain.IRepositories;
public interface IPatientRepo
{
    ICollection<Slot> GetAvailableSlots(Guid doctorId);
    AppointmentNotification BookAppointment(Guid patientId, Guid doctorId, Guid slotId);
}
