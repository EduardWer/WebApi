using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public partial class AdminAdmin
    {
        public int IdAdmin { get; set; }
        public string Surname { get; set; } = null!;
        public string Aname { get; set; } = null!;
        public string? Patronymic { get; set; }
        public string EnterPassword { get; set; } = null!;
    }
}
