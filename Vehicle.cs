namespace SWE203_RentalApp
{
    public class Vehicle
    {
        public string Model { get; set; }
        public double PricePerDay { get; set; }

        public Vehicle(string model, double pricePerDay)
        {
            Model = model;
            PricePerDay = pricePerDay;
        }
    }
}