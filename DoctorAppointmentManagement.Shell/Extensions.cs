using DoctorAppointmentManagement.Shell.Repositories;
using DoctorAppointmentManagement.Core.OutPorts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using DoctorAppointmentManagement.Core.InputPorts;
using DoctorAppointmentManagement.Core.Services;

namespace DoctorAppointmentManagement.Shell
{
    public static class Extensions
    {
        public static IServiceCollection AddAppointmentBookingManagementModule(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IAppointmentRepo, AppointmentRepo>();
            services.AddScoped<IAppointmentServicePort, AppointmentService>();
            return services;
        }
    }
}