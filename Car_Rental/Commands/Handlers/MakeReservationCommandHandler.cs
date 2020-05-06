using Car_Rental.Interfaces;
using Car_Rental.Model.Read;
using Car_Rental.Model.Write;
using System;
using System.Collections.Generic;
using System.Text;

namespace Car_Rental.Commands.Handlers
{
   public class MakeReservationCommandHandler : CommandHandlerBase , ICommandHandler<MakeReservationCommand>
    {
        public MakeReservationCommandHandler(ICarRentalUnityOfWork unityOfWork): base(unityOfWork)
        {
        }

        public void Execute(MakeReservationCommand command)
        {
            Car car = this._unityOfWork.CarRepository.Get(command.CarId);
            if (car == null)
            {
                throw new Exception($"Could not find Car'{command.CarId}'.");
            }
            Driver driver = this._unityOfWork.DriverRepository.Get(command.DriverId);
            if (driver == null)
            {
                throw new Exception($"Could not find car'{command.CarId}'");
            }

            var rental = new Rental()
            {
                RentalId = command.RentalId,
                StartDateTime = command.StartDateTime,
                StopDateTime = command.StopDateTime,
                Total = command.Total,
                CarId = command.CarId,
                DriverId = command.DriverId,
                Car = car,
                Driver = driver
            };
            this._unityOfWork.RentalRepository.Insert(rental);
            this._unityOfWork.Commit();
            //Upadate read Stack
            var rentalView = new RentalView()
            {
                RentalId = rental.RentalId,
                StartDateTime = rental.StartDateTime,
                StopDateTime = command.StopDateTime,
                Total = rental.Total,
                CarId = car.CarId,
                DriverId = driver.DriverId, 
                RegistrationNumber = car.RegistrationNumber
            };
            this._unityOfWork.RentalViewRepository.Insert(rentalView);
            this._unityOfWork.Commit();
        }
    }
}
