using DoctorAppointmentManagement.Shell.Dtos;
using AutoMapper;
using DoctorBooking.Shared.Models;

namespace AppointmentBooking.Infrastructure.Mappers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Appointment, AppointmentResponce>();
        }
    }
}
