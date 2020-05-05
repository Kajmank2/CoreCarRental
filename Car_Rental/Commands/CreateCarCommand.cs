﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Car_Rental.Commands.Handlers
{
  public  class CreateCarCommand : ICommandHandler
    {
        public Guid CarId { get; set; }
        public string RegistrationNumber { get; set; }
        public double XPosition { get; set; }
        public double YPosition { get; set; }
        public int CurrentDistance { get; set; }
        public int TotalDistance { get; set; }
    }
}
