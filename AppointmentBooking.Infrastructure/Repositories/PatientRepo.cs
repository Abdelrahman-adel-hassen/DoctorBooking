namespace AppointmentBooking.Infrastructure.Repositories
{
    public class PatientRepo(AppointmentBookingDbContext context, IDoctorShared doctorRepo, IMapper mapper) : IPatientRepo
    {

        public ICollection<Slot> GetAvailableSlots(Guid doctorId)
        {
            var Slots = doctorRepo.GetAvailableDoctorSlots(doctorId).ToList();

            return mapper.Map<List<Slot>>(Slots);
        }

        public AppointmentNotification BookAppointment(Guid patientId, Guid doctorId, Guid slotId)
        {
            //Todo  Return Result 
            var slot = doctorRepo.GetSlot(slotId);
            if (slot is null || slot.IsReserved)
            {
                //throw exception
                return null;
            }
            var patient = context.Patients.FirstOrDefault(x => x.Id == patientId);
            if (patient is null)
            {
                //throw exception
                return null;
            }
            var doctor = doctorRepo.GetDoctor(doctorId);
            if (doctor is null)
            {
                //throw exception
                return null;
            }
            var appointment = new Appointment() { PatientId = patientId, PatientName = patient.Name, SlotId = slotId };
            context.Appointments.AddRange(appointment);
            var isBooked = context.SaveChanges() > 0;
            if (!isBooked)
                return null;
            return new AppointmentNotification() { DoctorName = doctor.Name, PatientName = patient.Name, ReservedAt = appointment.ReservedAt };
        }

    }
}
