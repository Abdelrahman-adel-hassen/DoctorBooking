namespace DoctorAvailability.BLL;
public static class Extensions
{
    public static IServiceCollection AddBLLLayer(this IServiceCollection services)
    {
        services.AddScoped<IDoctorRepo, DoctorRepo>();
        services.AddScoped<IDoctorService, DoctorService>();
        return services;
    }
}
