namespace DoctorAvailability.DAL.Models
{
    internal class Doctor
    {
        public Guid Id { get; set; }
        public String Name { get; set; }
        public IEnumerable<Slot> Slots { get; set; } = new List<Slot>();
    }
}
