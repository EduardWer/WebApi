using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public partial class Doctor
    {
      

        public int IdDoctor { get; set; }
        public string Surname { get; set; } = null!;
        public string Dname { get; set; } = null!;
        public string? Patronymic { get; set; }
        public string EnterPassword { get; set; } = null!;
        public string WorkAddress { get; set; } = null!;
        public int IdSpecialty { get; set; }

       
    }
}
