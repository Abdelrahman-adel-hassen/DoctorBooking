namespace AppointmentBooking.API
{
    public static class Extensions
    {
        public static IServiceCollection AddAppointmentBookingModule(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddApplicationLayer();
            services.AddInfrastructureLayer(configuration);
            return services;
        }
    }
}
