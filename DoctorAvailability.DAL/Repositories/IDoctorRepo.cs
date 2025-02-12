﻿namespace DoctorAvailability.DAL.Repositories
{
    public interface IDoctorRepo
    {
        ICollection<Slot> GetDoctorSlots(Guid id);
        bool AddDoctorSlot(IEnumerable<Slot> slots);
    }
}
