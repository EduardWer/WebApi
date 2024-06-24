using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public partial class Appointment
    {
        public int IdAppointment { get; set; }
        public int IdDoctor { get; set; }
        public int IdPatient { get; set; }
        public int IdDirection { get; set; }
        public DateTime AppointmentDate { get; set; }
        public TimeSpan AppointmentTime { get; set; }
        public int IdStatus { get; set; }

       
    }
}
