namespace AppointmentBooking.Infrastructure.Mappers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<DoctorResonse,Doctor>();
            CreateMap<SlotResponse, Slot>();
        }
    }
}
