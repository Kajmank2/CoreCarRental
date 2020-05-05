using System;
using System.Collections.Generic;
using System.Text;

namespace Car_Rental.Commands
{
   public class CreateDriverCommand : ICommandHandler
    {
        public Guid DriverId { get; set; }
        public string LicenceNumber { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
    }
}
