using DoctorBooking.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointmentBooking.Domain.IRepositories;
public interface IPatientRepo
{
    IEnumerable<Slot> GetAvailableSlots();
}
