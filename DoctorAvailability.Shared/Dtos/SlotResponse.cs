namespace DoctorAvailability.Shared.Dtos
{
    public class SlotResponse
    {
        public DateTime Date { get; set; } = DateTime.UtcNow;
        public string DoctorName { get; set; } = string.Empty;
        public bool IsReserved { get; set; }
        public decimal Cost { get; set; }
    }
}
