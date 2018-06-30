using System;

namespace TAL.PremiumCalculatorEngine
{
    public class Customer
    {
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }
        public string Name { get; set; }
    }

    public enum Gender { Male,Female }
}