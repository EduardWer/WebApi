using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public partial class Patient
    {
       
        public int IdPatient { get; set; }
        public string Surname { get; set; } = null!;
        public string Pname { get; set; } = null!;
        public string? Patronymic { get; set; }
        public DateTime BirthDate { get; set; }
        public string Paddress { get; set; } = null!;
        public string? LivingAddress { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }

       
    }
}
