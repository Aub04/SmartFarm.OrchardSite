using OrchardCore.ContentManagement;
using System;

namespace SmartFarm.Module.Models
{
    public class FarmPart : ContentPart
    {
        public int CowCount { get; set; }
        public string CowBreed { get; set; }
        public DateTime? ArrivalDateUtc { get; set; }
    }
}
