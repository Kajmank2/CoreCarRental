using Car_Rental.Persistance;
using System;
using System.Collections.Generic;
using System.Text;

namespace Car_Rental.Queries.Handlers
{
   public class QueryHanlderBase
    {
        protected CarRentalContext _context;
        public QueryHanlderBase(CarRentalContext context)
        {
            this._context = context;
        }
    }
}
