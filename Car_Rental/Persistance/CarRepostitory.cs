using Car_Rental.Interfaces;
using Car_Rental.Model.Write;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System;

using System.Text;
using System.Linq.Expressions;

namespace Car_Rental.Persistance
{
    public class CarRepostitory : Repository<Car>, ICarRepository
    {
        public CarRepostitory(CarRentalContext context) : base (context)
        {

        }
        public Car GetCarWithName(string name)
        {
            Expression<Func<Car, bool>> expressionPredicate = x => x.RegistrationNumber == name;
            return this.Find(expressionPredicate).FirstOrDefault();
        }

        public IEnumerable<Car> GetKilometers()
        {
            Console.WriteLine("Kilometry z dystansem wiekszym niz 190km");
            return Context.Cars.Where(x => x.CurrentDistance > 190);
        }

        public CarRentalContext Context
        {
            get { return Context as CarRentalContext; }
        }
    }
}
