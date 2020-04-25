using Car_Rental.Interfaces;
using Car_Rental.Model.Write;
using System;
using System.Collections.Generic;
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
        public CarRentalContext Context
        {
            get { return Context as CarRentalContext; }
        }
    }
}
