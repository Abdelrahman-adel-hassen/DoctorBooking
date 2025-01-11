using DoctorBooking.Shared.Models;

namespace DoctorAvailability.DAL.Repositories
{
    public interface IDoctorRepo
    {
        IEnumerable<Slot> GetDoctorSlots(Guid id);
        bool AddDoctorSlot(IEnumerable<Slot> slots);
    }
}
