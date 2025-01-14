namespace DoctorAvailability.API;

public static class Extensions
{
    public static IServiceCollection AddDoctorAvailabilityModule(this IServiceCollection services, IConfiguration configuration)
    {

        services.AddBLLLayer();
        services.AddDALLayer(configuration);

        return services;
    }
}
