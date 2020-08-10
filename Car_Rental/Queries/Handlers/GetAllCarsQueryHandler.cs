using Car_Rental.DTO;
using Car_Rental.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Car_Rental.Queries.Handlers
{
  public  class GetAllCarsQueryHandler :QueryHanlderBase, IQueryHandler<GetAllCarQuery,List<CarDTO>>
    {
        public GetAllCarsQueryHandler(CarRentalContext context): base(context)
        {

        }

        public List<CarDTO> Execute(GetAllCarQuery query)
        {
            var cars = this._context.Cars.Select(r => new CarDTO()
            {
                CarId = r.CarId,
                CurrentDistance = r.CurrentDistance,
                RegistrationNumber = r.RegistrationNumber,
                TotalDistance = r.TotalDistance
            });
            return cars.ToList();
        }
    }
}
