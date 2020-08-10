using Car_Rental.Commands;
using Car_Rental.Commands.Handlers;
using Car_Rental.DTO;
using Car_Rental.Model.Write;
using Car_Rental.Persistance;
using Car_Rental.Queries;
using Car_Rental.Queries.Handlers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Car_Rental
{
    class ScenarioHelper
    {
        private CarRentalUnityofWork _unitOfWork = null;
        public ScenarioHelper(CarRentalUnityofWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }
        public void ShowDrivers()
        {
            Console.WriteLine("Drivers");
            Console.WriteLine("==============\n");
            GetAllDriversQuery query = new GetAllDriversQuery();
            GetAllDriversQueryHandlers handler = new GetAllDriversQueryHandlers(this._unitOfWork.Context);
            var visits = handler.Execute(query);
            foreach (DriverDTO dt in visits)
            {
                Console.WriteLine($"FirstName:     '{dt.FirstName}'");
                Console.WriteLine($"LicenceNumber:       '{dt.LicenceNumber}'");
                Console.WriteLine($"SecondName:      '{dt.SecondName}'");
                Console.WriteLine("--------------------------------------");
            }
        }

        public void ShowCar()
        {
            Console.WriteLine("Cars");
            Console.WriteLine("==============================\n");
            GetAllCarQuery query = new GetAllCarQuery();
            GetAllCarsQueryHandler handler = new GetAllCarsQueryHandler(this._unitOfWork.Context);
            var visits = handler.Execute(query);
            foreach (CarDTO car in visits)
            {
                Console.WriteLine($"CarNumber:     '{car.RegistrationNumber}'");
                Console.WriteLine($"CurrentDistance:       '{car.CurrentDistance}'");
                Console.WriteLine($"TotalDistance:      '{car.TotalDistance}'");
                Console.WriteLine("--------------------------------------");
            }

        }
        public Guid CreateCar(string registrationNumber, int TotalDist, Status status)
        {
            Guid carId = Guid.NewGuid();
            CreateCarCommand command = new CreateCarCommand()
            {
                CarId = carId,
                RegistrationNumber = registrationNumber,
                TotalDistance = TotalDist,
                Status = status
            };
            CreateCarCommandHandler handler = new CreateCarCommandHandler(this._unitOfWork);
            handler.Execute(command);

            return carId;
        }
        public Guid CreateDriver(string firstName, string secondName, string licenceNumber)
        {
            Guid driverId = Guid.NewGuid();
            CreateDriverCommand command = new CreateDriverCommand()
            {
                DriverId = driverId,
                FirstName = firstName,
                LicenceNumber = licenceNumber,
                SecondName = secondName,

            };
            CreateDriverCommandHandler handler = new CreateDriverCommandHandler(this._unitOfWork);
            handler.Execute(command);
            return driverId;
        }
        public Guid CreateRental(DateTime startDateTime, DateTime stopDateTime, decimal Total, Guid driverId, Guid carId)
        {
            Guid rentalId = Guid.NewGuid();
            CreateRentalCommand command = new CreateRentalCommand()
            {
                CarId = carId,
                DriverId = driverId,
                StartDateTime = startDateTime,
                StopDateTime = stopDateTime,
                Total = Total
            };
            CreateRentalCommandHandler handler = new CreateRentalCommandHandler(this._unitOfWork);
            handler.Execute(command);
            return rentalId;
        }
        public Guid MakeReservation(Guid carId, Guid driverId, decimal total, DateTime startDateTime, DateTime stopDateTime)
        {
            Guid rentalId = Guid.NewGuid();
            MakeReservationCommand command = new MakeReservationCommand()
            {
                RentalId = rentalId,
                CarId = carId,
                DriverId = driverId,
                StartDateTime = startDateTime,
                StopDateTime = stopDateTime,
                Total = total,

            };
            MakeReservationCommandHandler handler = new MakeReservationCommandHandler(this._unitOfWork);
            handler.Execute(command);

            return rentalId;
        }
        public void ReturnCar(Guid rentalId, Guid carId)
        {
            ReturnCarCommand command = new ReturnCarCommand()
            {
                carId = carId,
                reservationId = rentalId
            };
            ReturnCarCommandHandler handler = new ReturnCarCommandHandler(this._unitOfWork);
            handler.Execute(command);
        }

    }
}
