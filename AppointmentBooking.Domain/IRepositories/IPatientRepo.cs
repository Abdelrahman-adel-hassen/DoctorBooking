namespace AppointmentBooking.Domain.IRepositories;
public interface IPatientRepo
{
    ICollection<Slot> GetAvailableSlots(Guid doctorId);
    AppointmentDetails BookAppointment(Guid patientId, Guid doctorId, Guid slotId);
}
