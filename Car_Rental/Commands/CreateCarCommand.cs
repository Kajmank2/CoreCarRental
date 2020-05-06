using Car_Rental.Model.Write;
using System;
using System.Collections.Generic;
using System.Text;

namespace Car_Rental.Commands.Handlers
{
  public  class CreateCarCommand : ICommand
    {
        public Guid CarId { get; set; }
        public string RegistrationNumber { get; set; }
        public double XPosition { get; set; }
        public double YPosition { get; set; }
        public int CurrentDistance { get; set; }
        public int TotalDistance { get; set; }
        public Status  Status { get; set; }
    }
}
