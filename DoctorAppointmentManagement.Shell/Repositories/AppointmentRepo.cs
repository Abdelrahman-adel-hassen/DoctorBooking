using AppointmentBooking.Shared.Interfaces;
using AutoMapper;
using DoctorAppointmentManagement.Core.OutPorts;
using DoctorAppointmentManagement.Shell.Dtos;
using DoctorBooking.Shared.Models;

namespace DoctorAppointmentManagement.Shell.Repositories;
public class AppointmentRepo(IAppointmentShared appointmentRepo) : IAppointmentRepo
{
    private readonly IAppointmentShared _appointmentRepo = appointmentRepo;

    public bool CancelAppointment(Guid appointmentId)
    {
        var result = _appointmentRepo.CancelAppointment(appointmentId);
        return result;
    }

    public bool CompleteAppointment(Guid appointmentId)
    {
        var result = _appointmentRepo.CompleteAppointment(appointmentId);
        return result;
    }

    public ICollection<Appointment> GetUpcomingAppointments()
    {
        var appointments = _appointmentRepo.GetUpcomingAppointments();
        return appointments;
    }
}
