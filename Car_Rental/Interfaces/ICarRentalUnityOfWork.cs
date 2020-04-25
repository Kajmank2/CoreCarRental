using System;
using System.Collections.Generic;
using System.Text;

namespace Car_Rental.Interfaces
{
    public interface ICarRentalUnityOfWork 
    {
        ICarRepository CarRepository { get; }
        IDriverRepository DriverRepository { get; }
        IRentalRepository RentalRepository { get; }

        void Commit();
        void RejectChanges();
    }
}
