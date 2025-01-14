namespace DoctorAvailability.DAL
{
    public class DoctorAvailabilityDbContext : DbContext
    {
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Slot> Slots { get; set; }

        public DoctorAvailabilityDbContext(DbContextOptions<DoctorAvailabilityDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.HasDefaultSchema("DoctorAvailability");
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }
    }
}
