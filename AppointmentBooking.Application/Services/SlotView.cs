using AppointmentBooking.Domain.IRepositories;
using DoctorBooking.Shared.Models;

namespace AppointmentBooking.Application.Services;
public class SlotViewService(IPatientRepo patientRepo)
{
    private readonly IPatientRepo _patientRepo = patientRepo;

    public IEnumerable<Slot> GetAvailableSlots()
    {
        var slots = _patientRepo.GetAvailableSlots();

        return slots ?? default!;
    }
}
