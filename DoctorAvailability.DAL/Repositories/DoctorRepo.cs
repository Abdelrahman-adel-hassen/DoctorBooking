using DoctorAvailability.DAL.Models;

namespace DoctorAvailability.DAL.Repositories
{
    public class DoctorRepo : IDoctorRepo
    {
        public List<Slot> GetDoctorSlots(Guid id)
        {
            // This is where we would call the DAL to get the slots for a doctor
            return new List<Slot>();
        }
        public bool AddDoctorSlot(List<Slot> slots)
        {
            return true;
        }
    }
}
