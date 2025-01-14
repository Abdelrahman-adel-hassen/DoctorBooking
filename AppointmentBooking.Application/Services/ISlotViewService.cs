namespace AppointmentBooking.Application.Services
{
    public interface ISlotViewService
    {
        IEnumerable<Slot> GetAvailableSlots(Guid DoctorId);
    }
}
