using AppointmentBooking.Domain.IRepositories;
using DoctorBooking.DAL.Models;

namespace AppointmentBooking.Application.Services;
public class SlotView(IPatientRepo patientRepo)
{
    private readonly IPatientRepo _patientRepo = patientRepo;

    public IEnumerable<Slot> GetAvailableSlots()
    {
        var slots = _patientRepo.GetAvailableSlots();

        return slots ?? default!;
    }
}
