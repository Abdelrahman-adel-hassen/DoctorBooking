using AppointmentBooking.Shared.Interfaces;

namespace AppointmentBooking.Infrastructure
{
    public static class Extensions
    {
        public static IServiceCollection AddInfrastructureLayer(this IServiceCollection services,IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection") ??
            throw new InvalidOperationException("Connection String 'DefaultConnection' not found.");
            services.AddScoped<IPatientRepo, PatientRepo>();
            services.AddScoped<IAppointmentShared, AppointmentRepo>();
            services.AddAutoMapper(typeof(MappingProfile));
            services.AddDbContext<AppointmentBookingDbContext>(options => options.UseSqlServer(connectionString));
            return services;
        }
    }
}
