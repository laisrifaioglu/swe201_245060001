using System;

namespace SWE203_RentalApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer("Laith");

            Vehicle car = new Vehicle("Toyota Corolla", 100);
            Vehicle bike = new Vehicle("Yamaha Bike", 50);

            RentalService service = new RentalService();

            service.RentVehicle(customer, car, 3);
            service.RentVehicle(customer, bike, 2);

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}