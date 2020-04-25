using Car_Rental.Model.Write;
using System;
using System.Collections.Generic;
using System.Text;

namespace Car_Rental.Interfaces
{
   public interface IRentalRepository
    {
        void Add(Rental rental);
    }
}
