using DoctorBooking.DAL;
using DoctorBooking.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading;

namespace DoctorAvailability.DAL.Repositories
{
    public class DoctorRepo(ApplicationDbContext context)    {
        private readonly ApplicationDbContext _context = context;

        public IEnumerable<Slot> GetDoctorSlots(Guid id)
        {
            var DoctorExists =  _context.Doctors.Any(x => x.Id == id);

            if (!DoctorExists)
                return null!;

            var doctorSlots = _context.Slots
                    .Where(x => x.DoctorId == id)
                    .AsNoTracking()
                    .ToList();

            return doctorSlots;
        }

        public bool AddDoctorSlot(IEnumerable<Slot> slots)
        {
            _context.Slots.AddRange(slots);
            _context.SaveChanges();

            return true;
        }
    }
}
