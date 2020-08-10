using System;
using System.Collections.Generic;
using System.Text;

namespace Car_Rental.DTO
{
   public class CarDTO
    {
        public Guid CarId { get; set; }
        public string RegistrationNumber { get; set; }
        public int CurrentDistance { get; set; }
        public int TotalDistance { get; set; }
    }
}
