using System;
using System.Collections.Generic;
using System.Text;

namespace Car_Rental.DTO
{
   public class RentalDTO
    {
        public Guid RentalId { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime StopDateTime { get; set; }
        public decimal Total { get; set; }
        //Car 
        public Guid CarId { get; set; }
        //Driver
        public Guid DriverId { get; set; }
    }
}
