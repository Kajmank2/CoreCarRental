using Car_Rental.Model.Write;
using System;
using System.Collections.Generic;
using System.Text;

namespace Car_Rental.Interfaces
{
   public interface IRentalRepository : IRepository<Rental>
    {
        void Add(Rental rental);
        Rental GetRentalWithName(Guid name);
    }
}
