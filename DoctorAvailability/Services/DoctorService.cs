using DoctorAvailability.DAL.Models;
using DoctorAvailability.DAL.Repositories;

namespace DoctorAvailability.BLL.Services
{
    public class DoctorService(DoctorRepo doctorRepo)
    {
        private readonly DoctorRepo _doctorRepo = doctorRepo;

        public IEnumerable<Slot> GetDoctorSlots(Guid id)
        {
            if(id == Guid.Empty)
            {
                throw new ArgumentException("Doctor ID cannot be empty");
            }

            var doctorSlots = _doctorRepo.GetDoctorSlots(id);
            if(doctorSlots == null)
            {
                throw new ArgumentException("DoctorSlots are Empty");
            }
            return doctorSlots;
        }
        public bool AddDoctorSlot(IEnumerable<Slot>slots)
        {
            if (slots == null)
            {
                throw new ArgumentException("Slots cannot be empty");
            }
            var slotAdded = _doctorRepo.AddDoctorSlot(slots);
            if (!slotAdded)
            {
                throw new ArgumentException("Slots cannot be added");
            }
            return slotAdded;
        }
    }
}
