using AppointmentBooking.Shared.Interfaces;

namespace AppointmentBooking.Infrastructure.Repositories;
public class AppointmentRepo(AppointmentBookingDbContext context) : IAppointmentShared
{
    private readonly AppointmentBookingDbContext _dbContext = context;
    
    public bool CancelAppointment(Guid appointmentId)
    { 
    var appointment = _dbContext.Appointments.FirstOrDefault(a => a.Id == appointmentId);
        if (appointment == null)
        {
            return false;
        }
        appointment.IsCancelled = true;
        _dbContext.SaveChanges();
        return true;
    }

    public bool CompleteAppointment(Guid appointmentId)
    {
        var appointment = _dbContext.Appointments.FirstOrDefault(a => a.Id == appointmentId);
        if (appointment == null)
        {
            return false;
        }
        appointment.IsCompleted = true;
        _dbContext.SaveChanges();
        return true;
    }

    public ICollection<Appointment> GetUpcomingAppointments()
    {
        var appointments = _dbContext.Appointments
            .Where(a => a.ReservedAt > DateTime.Now)
            .AsNoTracking()
            .ToList();

        return appointments;
    }
}
