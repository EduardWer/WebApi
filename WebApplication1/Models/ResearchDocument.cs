using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public partial class ResearchDocument
    {
        public int IdResearchDocument { get; set; }
        public string Rtf { get; set; } = null!;
        public byte[]? Attachment { get; set; }

        
    }
}
