namespace DoctorAvailability.BLL.Services
{
    public interface IDoctorService
    {
        ICollection<Slot> GetDoctorSlots(Guid id);
        bool AddDoctorSlot(IEnumerable<Slot> slots);
    }
}
