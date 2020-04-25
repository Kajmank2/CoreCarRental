using Car_Rental.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Car_Rental.Persistance
{
    class CarRentalUnityOfWork
    {
        public class CarRentalUnityofWork : ICarRentalUnityOfWork
        {
            public CarRentalContext Context { get; protected set; }
            public ICarRepository CarRepository { get; }
            public IDriverRepository DriverRepository { get; }
            public IRentalRepository RentalRepository { get; }

            public CarRentalUnityofWork(CarRentalContext context)
            {
                this.Context = context;
                this.CarRepository = new CarRepostitory(this.Context);
                this.DriverRepository = new DriverRepository(this.Context);
                this.RentalRepository = new RentalRepostiory(this.Context);
            }

            public void Commit()
            {
                Context.SaveChanges();
            }
            public void Dispose()
            {
                Context.Dispose();
            }
            public void RejectChanges()
            {
                foreach (var entry in Context.ChangeTracker.Entries()
             .Where(e => e.State != EntityState.Unchanged))
                {
                    switch (entry.State)
                    {
                        case EntityState.Added:
                            entry.State = EntityState.Detached;
                            break;
                        case EntityState.Modified:
                        case EntityState.Deleted:
                            entry.Reload();
                            break;
                    }
                }
            }
        }
    }
}
