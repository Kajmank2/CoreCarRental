using System;
using System.Collections.Generic;
using System.Text;

namespace Car_Rental.Model.Write
{
   public class Rental
    {
        public Guid RentalId { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime StopDateTime { get; set; }
        public decimal Total { get; set; }
        //Car 
        public Guid CarId { get; set; }
        public Car Car { get; set; }
        //Driver
        public Guid DriverId { get; set; }
        public Driver Driver { get; set; }
    }
}