namespace DoctorAvailability.DAL.Repositories
{
    public class DoctorRepo(DoctorAvailabilityDbContext context) : IDoctorRepo
    {

        public ICollection<Slot> GetDoctorSlots(Guid id)
        {
            var Doctors = context.Doctors.Any(x => x.Id == id);

            if (!Doctors)
                return null!;

            var doctorSlots = context.Slots
                    .Where(x => x.DoctorId == id)
                    .AsNoTracking()
                    .ToList();

            return doctorSlots;
        }

        public bool AddDoctorSlot(IEnumerable<Slot> slots)
        {
            // add validation if doctor has same slot interval
            context.Slots.AddRange(slots);
            context.SaveChanges();

            return true;
        }
    }
}
