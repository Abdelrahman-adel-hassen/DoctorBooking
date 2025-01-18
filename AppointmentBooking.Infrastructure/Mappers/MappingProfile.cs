
namespace AppointmentBooking.Infrastructure.Mappers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<SlotResponse, Slot>();
        }
    }
}
