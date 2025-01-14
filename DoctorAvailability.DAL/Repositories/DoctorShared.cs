namespace DoctorAvailability.DAL.Repositories
{
    internal class DoctorShared(DoctorAvailabilityDbContext context, IMapper mapper) : IDoctorShared
    {

        public ICollection<SlotResponse> GetAvailableDoctorSlots(Guid doctorId)
        {
            var slots = context.Slots.Where(s => !s.IsReserved && s.DoctorId == doctorId).ToList();
            return mapper.Map<List<SlotResponse>>(slots);
        }

        public DoctorResonse GetDoctor(Guid doctorId)
        {
            var doctor = context.Doctors.FirstOrDefault(d => d.Id == doctorId);
            return mapper.Map<DoctorResonse>(doctor);
        }

        public SlotResponse GetSlot(Guid slotId)
        {
            var slot = context.Slots.FirstOrDefault(d => d.Id == slotId);
            return mapper.Map<SlotResponse>(slot);
        }
        public bool ReserveSlot(Guid slotId)
        {
            var slot = context.Slots.FirstOrDefault(d => d.Id == slotId);
            if (slot is not null)
                slot.IsReserved = true;
            return context.SaveChanges() > 0;
        }
    }
}
