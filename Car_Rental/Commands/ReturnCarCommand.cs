using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Car_Rental.Commands
{
   public class ReturnCarCommand : ICommand
    {
        public Guid carId { get; set; }
    }
}
