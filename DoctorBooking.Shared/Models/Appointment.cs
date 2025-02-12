﻿namespace DoctorBooking.Shared.Models;
public class Appointment
{
    public Guid Id { get; set; }
    public Guid SlotId { get; set; }
    public Guid PatientId { get; set; }
    public string PatientName { get; set; } = string.Empty;
    public DateTime ReservedAt { get; set; } = DateTime.UtcNow;
    public bool IsCancelled { get; set; }
    public bool IsCompleted { get; set; }
}
