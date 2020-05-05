using Car_Rental.Model.Write;
using System;
using System.Collections.Generic;
using System.Text;

namespace Car_Rental.Interfaces
{
   public interface IDriverRepository : IRepository<Driver>
    {
        Driver GetDriverWithName(string name);
    }
}
