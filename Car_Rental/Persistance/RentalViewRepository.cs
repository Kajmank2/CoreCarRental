using Car_Rental.Interfaces;
using Car_Rental.Model.Read;
using System;
using System.Collections.Generic;
using System.Text;

namespace Car_Rental.Persistance
{
   public class RentalViewRepository : Repository<RentalView>, IRentalViewRepository
    {
        public RentalViewRepository(CarRentalContext context) : base(context)
        {
        }
    }
}
