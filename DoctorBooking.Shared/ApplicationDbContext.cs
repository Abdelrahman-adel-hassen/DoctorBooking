using DoctorBooking.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace DoctorBooking.Shared;
public class ApplicationDbContext : DbContext
{
    public DbSet<Doctor> Doctors { get; set; }
    public DbSet<Slot> Slots { get; set; }
    public DbSet<Appointment> Appointments { get; set; }
    public DbSet<Patient> Patients { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}
