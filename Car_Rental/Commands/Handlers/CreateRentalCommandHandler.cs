using Car_Rental.Interfaces;
using Car_Rental.Model.Write;
using System;
using System.Collections.Generic;
using System.Text;

namespace Car_Rental.Commands.Handlers
{
    public class CreateRentalCommandHandler : CommandHandlerBase, ICommandHandler<CreateRentalCommand>
    {
        public CreateRentalCommandHandler(ICarRentalUnityOfWork unityOfWork) : base(unityOfWork)
        {

        }
        public void Execute(CreateRentalCommand command)
        {
            Rental rental = this._unityOfWork.RentalRepository.GetRentalWithName(command.RentalId);
            if (rental != null)
            {
                throw new Exception($"Driver'{command.RentalId}'already exsist");
            }
            rental = new Rental()
            {
                RentalId = command.RentalId,
                CarId = command.CarId,
                DriverId = command.DriverId,
                StartDateTime = command.StartDateTime,
                StopDateTime = command.StopDateTime,
                Total = command.Total
            };
            this._unityOfWork.RentalRepository.Insert(rental);
            this._unityOfWork.Commit();
        }
    }
}
