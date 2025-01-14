using DoctorAvailability.Shared.Dtos;

namespace DoctorAvailability.Shared.Interfaces
{
    public interface IDoctorShared
    {
        ICollection<SlotResponse> GetAvailableDoctorSlots(Guid doctorId);
        SlotResponse GetSlot(Guid slotId);
        DoctorResonse GetDoctor(Guid doctorId);
        bool ReserveSlot(Guid slotId);
        //Collection<SlotDto> GetAvailableSlots(Guid doctorId);
    }
}
