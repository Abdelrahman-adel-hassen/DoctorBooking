namespace DoctorAvailability.BLL.Services
{
    public class DoctorService(IDoctorRepo doctorRepo) : IDoctorService
    {

        public ICollection<Slot> GetDoctorSlots(Guid id)
        {
            if (id == Guid.Empty)
            {
                throw new ArgumentException("Doctor ID cannot be empty");
            }
            var doctorSlots = doctorRepo.GetDoctorSlots(id);

            return doctorSlots ?? default!;
        }
        public bool AddDoctorSlot(IEnumerable<Slot> slots)
        {
            if (slots is null || !slots.Any())
            {
                throw new ArgumentException("Slots cannot be empty");
            }
            var slotAdded = doctorRepo.AddDoctorSlot(slots);
            if (!slotAdded)
            {
                throw new ArgumentException("Slots cannot be added");
            }
            return slotAdded;
        }
    }
}
