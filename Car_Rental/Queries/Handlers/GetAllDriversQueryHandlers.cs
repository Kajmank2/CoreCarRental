using Car_Rental.DTO;
using Car_Rental.Model.Write;
using Car_Rental.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Car_Rental.Queries.Handlers
{
  public  class GetAllDriversQueryHandlers : QueryHanlderBase, IQueryHandler<GetAllDriversQuery, List<DriverDTO>>
    {
        public GetAllDriversQueryHandlers(CarRentalContext context): base(context)
        {
        }

        public List<DriverDTO> Execute(GetAllDriversQuery query)
        {
            var drivers = this._context.Drivers.Select(x => new DriverDTO()
            {
                DriverId = x.DriverId,
                FirstName = x.FirstName,
                LicenceNumber = x.LicenceNumber,
                SecondName = x.SecondName
            });
            return drivers.ToList();
        }
    }
}
