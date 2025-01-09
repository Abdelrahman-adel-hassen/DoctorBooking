namespace DoctorAvailability.DAL.Models
{
    public class Doctor
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public ICollection<Slot> Slots { get; set; } = [];
    }
}
