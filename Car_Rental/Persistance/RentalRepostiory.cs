using Car_Rental.Interfaces;
using Car_Rental.Model.Write;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Car_Rental.Persistance
{
    public class RentalRepostiory : Repository<Rental>, IRentalRepository
    {
        public RentalRepostiory(CarRentalContext context)
: base(context) { }
        public void Add(Rental rental)
        {
            rental.StartDateTime = DateTime.Now;
            Context.Set<Rental>().Add(rental);
            Context.SaveChanges();
        }

        public Rental GetRentalWithName(Guid name)
        {
            Expression<Func<Rental, bool>> expressionPredicate = x => x.RentalId == name;
            return this.Find(expressionPredicate).FirstOrDefault();
        }


        public CarRentalContext Context
        {
            get { return Context as CarRentalContext; }
        }
    }
}
