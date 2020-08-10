using System;
using System.Collections.Generic;
using System.Text;

namespace Car_Rental.DTO
{
  public  class DriverDTO
    {
        public Guid DriverId { get; set; }
        public string LicenceNumber { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
    }
}
