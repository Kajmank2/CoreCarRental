using System;
using System.Collections.Generic;
using System.Text;

namespace Car_Rental.Commands
{
   public class MakeReservationCommand : ICommandHandler
    {
        public Guid RentalId { get; set; }
        public Guid CarId { get; set; }
        public Guid DriverId { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime StopDateTime { get; set; }
        public decimal Total { get; set; }
        public string RegistrationNumber { get; set; }

    }
}
