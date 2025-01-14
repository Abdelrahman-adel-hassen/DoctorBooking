namespace AppointmentBooking.Infrastructure
{
    public class AppointmentBookingDbContext : DbContext
    {
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Patient> Patients { get; set; }

        public AppointmentBookingDbContext(DbContextOptions<AppointmentBookingDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.HasDefaultSchema("AppointmentBooking");
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }
    }
}
