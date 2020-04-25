using Car_Rental.Model.Write;
using System;
using System.Collections.Generic;
using System.Text;

namespace Car_Rental.Interfaces
{
   public interface ICarRepository : IRepository<Car>
    {
        Car GetCarWithName(string name);
        IEnumerable<Car> GetKilometers();
    }
}
