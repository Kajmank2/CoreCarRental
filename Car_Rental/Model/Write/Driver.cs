using System;
using System.Collections.Generic;
using System.Text;

namespace Car_Rental.Model.Write
{
   public class Driver
    {
        public Guid DriverId { get; set; }
        public string LicenceNumber { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public ICollection<Rental> Rentals { get; set; }
    }
}
