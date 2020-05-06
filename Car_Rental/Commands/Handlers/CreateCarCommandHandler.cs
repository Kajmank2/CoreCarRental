using Car_Rental.Interfaces;
using Car_Rental.Model.Write;
using System;
using System.Collections.Generic;
using System.Text;

namespace Car_Rental.Commands.Handlers
{
    public class CreateCarCommandHandler : CommandHandlerBase, ICommandHandler<CreateCarCommand>
    {
        public CreateCarCommandHandler(ICarRentalUnityOfWork unityOfWork): base(unityOfWork)
        {

        }
        public void Execute(CreateCarCommand command)
        {
            Car car = this._unityOfWork.CarRepository.GetCarWithName(command.RegistrationNumber);
            if (car != null)
            {
                throw new Exception($"Car'{command.RegistrationNumber}'already exsist");
            }
            car = new Car()
            {
                CarId = command.CarId,
                RegistrationNumber = command.RegistrationNumber,
                TotalDistance = command.TotalDistance,
                CurrentDistance = command.CurrentDistance,
                Statuss = command.Status
            };
            this._unityOfWork.CarRepository.Insert(car);
            this._unityOfWork.Commit();
        }
    }
}
