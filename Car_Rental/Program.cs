using Car_Rental.Interfaces;
using Car_Rental.Model.Write;
using Car_Rental.Persistance;
using System;

namespace Car_Rental
{
    class Program 
    {
        static void Main(string[] args)
        {


            CarRentalContext context = new CarRentalContext();

            ClearDatabase(context);
            Car car = new Car()
            {
                CurrentDistance = 120000,
                RegistrationNumber = "WRa 1321",
                TotalDistance = 120000,
                XPosition = 12.2321,
                YPosition = 12.321,
            };
            Driver driver = new Driver()
            {
                FirstName = "Jacek",
                SecondName = "Przepiorka",
                LicenceNumber = "WRa232121",
                Rentals = null
            };
            Rental rental = new Rental()
            {
                StartDateTime = DateTime.Now,
                StopDateTime = DateTime.Now.AddMinutes(15),
                Total = 1500,
                Driver = driver,
                Car = car
            };

            using (var unityofWork = new CarRentalUnityofWork(context))
            {
                var scenarioHelper = new ScenarioHelper(unityofWork);
                unityofWork.Context.Cars.Add(car);
                unityofWork.Context.Drivers.Add(driver);
                unityofWork.Context.Rentals.Add(rental);
                context.SaveChanges();
                Console.WriteLine("Hejka ");
                Console.ReadKey();

                Guid car1 = scenarioHelper.CreateCar("KAROL", 1232121);
                Guid driver1 = scenarioHelper.CreateDriver("Leszek", "Jemiołek", "1232131asc");
                Guid rental1 = scenarioHelper.CreateRental(DateTime.Now, DateTime.Now.AddDays(1), 12330, driver.DriverId, car.CarId);
                context.SaveChanges();
                Console.WriteLine("(-+-)");
                Console.ReadKey();
                Guid reservation = scenarioHelper.MakeReservation(car1, driver1, 1200, DateTime.Now, DateTime.Now.AddDays(1));
                Console.WriteLine("Witam SCENARIO HELPER GOONA WINA THIS ");
                Console.WriteLine("Rental Created");
            }
            Console.ReadKey();

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

