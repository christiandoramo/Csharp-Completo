using System;

namespace _09ex01_02_03.src.Entities.Classes
{
    class Client
    {
        private string Name { get; set; }
        private string Email { get; set; }
        private DateTime BirthDate { get; set; }

        public Client(string name, string email, DateTime birthDate)
        {
            Name = name;
            Email = email;
            BirthDate = birthDate;
        }

        public override string ToString()
        {
            return $"{Name} ({BirthDate.ToShortDateString()}) - {Email}";
        }
    }
}
