using Appointment.Shared.DTO;
using AppointmentBooking.Domain.IRepositories;
using DoctorBooking.Shared;
using DoctorBooking.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace AppointmentBooking.Infrastructure.Repositories
{
    public class PatientRepo(ApplicationDbContext context) : IPatientRepo
    {
        private readonly ApplicationDbContext _context = context;

        public IEnumerable<Slot> GetAvailableSlots()
        {
            var Slots = _context.Slots
                    .Where(x => !x.IsReserved)
                    .AsNoTracking()
                    .ToList();

            return Slots;
        }

        public AppointmentDetails BookAppointment(Guid patientId, Guid doctorId, Guid slotId)
        {
            var slot = _context.Slots.FirstOrDefault(x => x.Id == slotId && !x.IsReserved);
            if (slot is null)
            {
                return null;
            }
            var patient = _context.Patients.FirstOrDefault(x => x.Id == patientId);
            if (patient is null)
            {
                return null;
            }
            var doctor = _context.Doctors.FirstOrDefault(x => x.Id == doctorId);
            if (doctor is null)
            {
                return null;
            }
            var appointment = new DoctorBooking.Shared.Models.Appointment() { PatientId = patientId, PatientName = patient.Name, SlotId = slotId };
            _context.Appointments.AddRange(appointment);
            _context.SaveChanges();

            return new AppointmentDetails() { DoctorName = doctor.Name, PatientName = patient.Name, ReservedAt = appointment.ReservedAt };
        }

    }
}
