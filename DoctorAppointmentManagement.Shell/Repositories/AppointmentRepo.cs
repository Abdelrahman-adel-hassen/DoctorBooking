using AppointmentBooking.Shared.Interfaces;
using AutoMapper;
using DoctorAppointmentManagement.Core.OutPorts;
using DoctorBooking.Shared.Models;

namespace DoctorAppointmentManagement.Shell.Repositories;
public class AppointmentRepo(IAppointmentShared appointmentRepo) : IAppointmentRepo
{

    public bool CancelAppointment(Guid appointmentId)
    {
        var result = appointmentRepo.CancelAppointment(appointmentId);
        return result;
    }

    public bool CompleteAppointment(Guid appointmentId)
    {
        var result = appointmentRepo.CompleteAppointment(appointmentId);
        return result;
    }

    public ICollection<Appointment> GetUpcomingAppointments()
    {
        var appointments = appointmentRepo.GetUpcomingAppointments();
        return appointments;
    }
}
