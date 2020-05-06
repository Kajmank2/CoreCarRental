using Car_Rental.Interfaces;
using Car_Rental.Model.Write;
using System;
using System.Collections.Generic;
using System.Text;

namespace Car_Rental.Commands.Handlers
{
    public class ReturnCarCommandHandler : CommandHandlerBase, ICommandHandler<ReturnCarCommand>
    {
        public ReturnCarCommandHandler(ICarRentalUnityOfWork unityOfWork) : base(unityOfWork)
        { }

        public void Execute(ReturnCarCommand command)
        {
            Car car = this._unityOfWork.CarRepository.Get(command.carId);
            if (car == null)
            {
                throw new Exception($"Could not find a car {command.carId}.");
            }
            
        }

    }
}
