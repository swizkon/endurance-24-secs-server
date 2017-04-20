using System;

namespace XingZen.Model
{
    public class Account
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public decimal Balance { get; set; }

        public Account()
        {
            Name = "Le Mans";
            this.Id = Guid.NewGuid();
        }
    }
}