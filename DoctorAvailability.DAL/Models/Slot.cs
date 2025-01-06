namespace DoctorAvailability.DAL.Models
{
    public class Slot
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public Guid DoctorId { get; set; }
        public bool IsReserved { get; set; }
        public Decimal Cost { get; set; }
    }
}
