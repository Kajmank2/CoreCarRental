﻿using Car_Rental.Commands;
using Car_Rental.Commands.Handlers;
using Car_Rental.Model.Write;
using Car_Rental.Persistance;
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
        public Guid CreateCar(string registrationNumber, int TotalDist,Status status)
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
