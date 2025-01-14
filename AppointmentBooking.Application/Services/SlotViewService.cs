namespace AppointmentBooking.Application.Services;
public class SlotViewService(IPatientRepo patientRepo) : ISlotViewService
{
    public IEnumerable<Slot> GetAvailableSlots(Guid DoctorId)
    {
        var slots = patientRepo.GetAvailableSlots(DoctorId);

        return slots ?? default!;
    }
}
