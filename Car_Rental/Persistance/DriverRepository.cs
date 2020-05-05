using Car_Rental.Interfaces;
using Car_Rental.Model.Write;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Car_Rental.Persistance
{
    public class DriverRepository : Repository<Driver>, IDriverRepository
    {
        public DriverRepository(CarRentalContext context) : base(context)
        {

        }
        public void Add(Driver entity)
        {
            Context.Set<Driver>().Add(entity);
            Context.SaveChanges();
        }

        public Driver GetDriverWithName(string name)
        {
            Expression<Func<Driver, bool>> expressionPredicate = x => x.LicenceNumber == name;
            return this.Find(expressionPredicate).FirstOrDefault();
        }

        public CarRentalContext Context
        {
            get { return Context as CarRentalContext; }
        }
    }
}
