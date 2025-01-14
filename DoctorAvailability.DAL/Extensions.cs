namespace DoctorAvailability.DAL
{
    public static class Extensions
    {
        public static IServiceCollection AddDALLayer(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection") ??
            throw new InvalidOperationException("Connection String 'DefaultConnection' not found.");
            services.AddDbContext<DoctorAvailabilityDbContext>(options => options.UseSqlServer(connectionString));
            services.AddScoped<IDoctorRepo, DoctorRepo>();
            services.AddScoped<IDoctorShared, DoctorShared>();
            services.AddAutoMapper(typeof(MappingProfile));

            return services;
        }
    }
}
