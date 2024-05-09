using System;

public class Phone
{
    public string Model { get; private set; }
    public string Manufacturer { get; private set; }
    public double Price { get; private set; }

    public Phone(string model, string manufacturer, double price)
    {
        Model = model;
        Manufacturer = manufacturer;
        Price = price;
    }

    public void ChangeModel(string newModel)
    {
        Model = newModel;
    }

    public void ChangeManufacturer(string newManufacturer)
    {
        Manufacturer = newManufacturer;
    }

    public void ChangePrice(double newPrice)
    {
        Price = newPrice;
    }

    public override string ToString()
    {
        return $"Model: {Model}, Manufacturer: {Manufacturer}, Price: {Price}";
    }
}
