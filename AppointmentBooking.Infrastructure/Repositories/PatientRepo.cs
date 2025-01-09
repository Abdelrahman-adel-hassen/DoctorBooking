using DoctorBooking.DAL;
using DoctorBooking.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace AppointmentBooking.DAL.Repositories
{
    public class DoctorRepo(ApplicationDbContext context)    {
        private readonly ApplicationDbContext _context = context;

        public IEnumerable<Slot> GetAvailableSlots()
        {
            var Slots = _context.Slots
                    .Where(x => !x.IsReserved)
                    .AsNoTracking()
                    .ToList();

            return Slots;
        }

        public bool AddAppointmentSlot(Guid patientId, Guid SlotId)
        {
            var slot = _context.Slots.FirstOrDefault(x => x.Id == SlotId && !x.IsReserved);

            //_context.Slots.AddRange(slots);
            //_context.SaveChanges();

            //return true;
        }
    }
}
