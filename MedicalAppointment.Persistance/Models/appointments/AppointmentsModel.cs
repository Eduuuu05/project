﻿

namespace MedicalAppointment.Persistance.Models.appointments
{
    public sealed class AppointmentsModel
    {
        public int AppointmentID { get; set; }
        public int PatientID { get; set; }
        public int DoctorID { get; set; }
        public DateTime AppointmentDate { get; set; }
        public int StatusID { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdateAt { get; set;  }

    }
}
