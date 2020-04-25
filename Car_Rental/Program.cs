using Car_Rental.Interfaces;
using Car_Rental.Persistance;
using System;

namespace Car_Rental
{
    class Program
    {
        static void Main(string[] args)
        {
          using CarRentalContext context = new CarRentalContext();
            // clear database
            //ClearDatabase(context);

            using (var unityOfWork = new CarRentalUnityofWork(new CarRentalContext))
            {
                // DO Naprawy
     

                Console.WriteLine("Hejka ");
                Console.ReadKey();
            }
        }
        private static void ClearDatabase(CarRentalContext context)
        {
            // clear database
            context.Cars.Clear();
            context.Rentals.Clear();
            context.RentalViews.Clear();
            context.Drivers.Clear();
            context.SaveChanges();
        }
    }
}

