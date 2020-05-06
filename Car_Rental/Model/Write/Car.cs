using System;
using System.Collections.Generic;
using System.Text;

namespace Car_Rental.Model.Write
{
    public class Car
    {
        public Guid CarId { get; set; }
        public string RegistrationNumber { get; set; }
        public double XPosition { get; set; }
        public double YPosition { get; set; }
        public int CurrentDistance { get; set; }
        public int TotalDistance { get; set; }
        public Status Status { get; set; }
        public ICollection<Rental> Rentals { get; set; }
    }
    public enum Status
    {
        Wolny = 0,
        Zarezerwowany = 1,
        Wypozyczony = 2
    }
}
