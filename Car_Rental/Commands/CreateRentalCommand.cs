using Car_Rental.Model.Write;
using System;
using System.Collections.Generic;
using System.Text;

namespace Car_Rental.Commands
{
   public class CreateRentalCommand :ICommand
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
