using Car_Rental.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Car_Rental.Commands
{
  public  class CommandHandlerBase
    {
        protected ICarRentalUnityOfWork _unityOfWork;
        public CommandHandlerBase(ICarRentalUnityOfWork unityOfWork)
        {
            this._unityOfWork = unityOfWork;
        }
    }
}
