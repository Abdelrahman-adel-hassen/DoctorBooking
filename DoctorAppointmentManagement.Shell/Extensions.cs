
using DoctorAppointmentManagement.Shell.Repositories;
using DoctorAppointmentManagement.Shell.Database;
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
            var connectionString = configuration.GetConnectionString("DefaultConnection") ??
            throw new InvalidOperationException("Connection String 'DefaultConnection' not found.");
            services.AddScoped<IAppointmentRepo, AppointmentRepo>();
            services.AddScoped<AppointmentServicePort, AppointmentService>();
            //services.AddAutoMapper(typeof(MappingProfile));
            services.AddDbContext<DoctorAppointmentManagementDbContext>(options => options.UseSqlServer(connectionString));

            return services;
        }
    }
}