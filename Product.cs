using System;

public class Product
{
    // member variables
    private string name;
    private double price;

    // properties
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public double Price
    {
        get { return price; }
        set { price = value; }
    }

    // empty constructor
    public Product()
    {
        name = "";
        price = 0.0;
    }

    // constructor with parameters
    public Product(string name, double price)
    {
        this.name = name;
        this.price = price;
    }

    // member function
    public double ApplyDiscount(double percentage)
    {
        if (percentage < 0) percentage = 0;
        if (percentage > 100) percentage = 100;

        return price - (price * percentage / 100.0);
    }

    // override ToString
    public override string ToString()
    {
        return $"Product: {name}, Price: {price:0.00} TL";
    }
}
