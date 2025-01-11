namespace Appointment.Shared.DTO
{
    public class AppointmentDetails
    {
        public string PatientName { get; init; }
        public string DoctorName { get; init; }
        public DateTime ReservedAt { get; init; } 
    }
}
