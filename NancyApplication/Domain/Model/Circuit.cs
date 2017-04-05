


using System;

namespace Endurance.Domain.Model
{
    public class Circuit
    {
        public Guid CircuitId { get; set; }

        public string Name { get; set; }

        public Circuit()
        {
            Name = "Le Mans";
            this.CircuitId = Guid.NewGuid();
        }
    }
}