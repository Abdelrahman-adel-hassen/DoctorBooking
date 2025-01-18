namespace DoctorBooking.Shared.Models
{
    public class AppointmentDetails
    {
        public DateTime ReservedAt { get; set; }
        public string DoctorName { get; set; } = string.Empty;
        public string PatientName { get; set; } = string.Empty;

    }
}
