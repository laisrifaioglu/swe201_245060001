using System;

namespace SWE203_RentalApp
{
    public class RentalService
    {
        public void RentVehicle(Customer customer, Vehicle vehicle, int days)
        {
            double totalPrice = vehicle.PricePerDay * days;

            Console.WriteLine($"{customer.Name} rented {vehicle.Model}");
            Console.WriteLine($"Days: {days}");
            Console.WriteLine($"Total Price: {totalPrice} TL\n");
        }
    }
}