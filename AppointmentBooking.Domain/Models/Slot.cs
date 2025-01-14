namespace AppointmentBooking.Domain.Models
{
    public class Slot
    {
        public DateTime Date { get; set; } = DateTime.UtcNow;
        public string DoctorName { get; set; } = string.Empty;
        public decimal Cost { get; set; }
    }
}
