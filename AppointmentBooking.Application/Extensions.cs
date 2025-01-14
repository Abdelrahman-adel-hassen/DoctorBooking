namespace AppointmentBooking.Application
{
    public static class Extensions
    {
        public static IServiceCollection AddApplicationLayer(this IServiceCollection services)
        {
            services.AddScoped<IAppointmentBookService, AppointmentBookService>();
            services.AddScoped<ISlotViewService, SlotViewService>();
            return services;
        }
    }
}
