namespace DoctorAvailability.DAL.Mappers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Doctor, DoctorResonse>();
            CreateMap<Slot, SlotResponse>();
        }
    }
}
