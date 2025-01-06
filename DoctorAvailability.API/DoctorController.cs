using DoctorAvailability.BLL.Services;
using DoctorAvailability.DAL.Models;
using Microsoft.AspNetCore.Mvc;

namespace DoctorAvailability.API
{
    [ApiController]
    [Route("[controller]")]
    public class DoctorController : ControllerBase
    {
        DoctorService doctorService = new();
        [HttpGet]

        public List<Slot> GetDoctorSlots(Guid id)
        { 
            return doctorService.GetDoctorSlots(id);
        }
        [HttpPost]

        public bool AddDoctorSlot(List<Slot> slots)
        {
            return doctorService.AddDoctorSlot(slots);
        }
    }
}
