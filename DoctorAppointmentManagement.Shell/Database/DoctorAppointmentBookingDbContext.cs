using DoctorAppointmentManagement.Core;
using Microsoft.EntityFrameworkCore;

namespace DoctorAppointmentManagement.Shell.Database
{
    public class DoctorAppointmentManagementDbContext : DbContext
    {
        public DoctorAppointmentManagementDbContext(DbContextOptions<DoctorAppointmentManagementDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.HasDefaultSchema("DoctorAppointmentManagement");
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }
    }
}
