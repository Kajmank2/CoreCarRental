using Car_Rental.Interfaces;
using Car_Rental.Model.Write;
using System;
using System.Collections.Generic;
using System.Text;

namespace Car_Rental.Commands.Handlers
{
   public class CreateDriverCommandHandler : CommandHandlerBase, ICommandHandler<CreateDriverCommand>
    {
        public CreateDriverCommandHandler(ICarRentalUnityOfWork unityOfWork):base(unityOfWork)
        {

        }

        public void Execute(CreateDriverCommand command)
        {
            Driver driver = this._unityOfWork.DriverRepository.GetDriverWithName(command.LicenceNumber);
            if (driver !=null)
            {
                throw new Exception($"Driver'{command.LicenceNumber}'already exsist");
            }
            driver = new Driver()
            {
                DriverId = command.DriverId,
                FirstName = command.FirstName,
                LicenceNumber = command.LicenceNumber,
                SecondName = command.SecondName
            };
            this._unityOfWork.DriverRepository.Insert(driver);
            this._unityOfWork.Commit();
        }
    }
}
