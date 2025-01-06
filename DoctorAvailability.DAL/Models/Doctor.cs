namespace DoctorAvailability.DAL.Models
{
    public class Doctor
    {
        public Guid Id { get; set; }
        public String Name { get; set; } = String.Empty;
        public IEnumerable<Slot> Slots { get; set; } = new List<Slot>();
    }
}
