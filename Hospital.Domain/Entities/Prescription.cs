﻿using Hospital.Domain.Commons;

namespace Hospital.Domain.Entities;

public class Prescription : Auditable
{
    public long UserId { get; set; }
    public User User { get; set; }
    public long DoctorId { get; set; }
    public Doctor Doctor { get; set; }
    public DateTime DateTime { get; set; }
    public ICollection<PrescriptionItem> Items { get; set; }
}