using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Create Product objects
        Product shawarma = new Product("Shawarma Wrap", 200);
        Product peanutChicken = new Product("Peanut Chicken Tenders", 260);

        Console.WriteLine("Original Products:");
        Console.WriteLine(shawarma);
        Console.WriteLine(peanutChicken);

        Console.WriteLine();
        Console.WriteLine("After Discount:");

        double newPrice1 = shawarma.ApplyDiscount(10);
        double newPrice2 = peanutChicken.ApplyDiscount(15);

        Console.WriteLine($"Discounted price of {shawarma.Name}: {newPrice1:0.00} TL");
        Console.WriteLine($"Discounted price of {peanutChicken.Name}: {newPrice2:0.00} TL");

        Console.WriteLine();
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
