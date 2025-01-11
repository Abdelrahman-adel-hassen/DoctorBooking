using Appointment.Shared.DTO;
using DoctorBooking.Shared.Models;

namespace AppointmentBooking.Domain.IRepositories;
public interface IPatientRepo
{
    IEnumerable<Slot> GetAvailableSlots();
    AppointmentDetails BookAppointment(Guid patientId, Guid doctorId, Guid slotId);
}
