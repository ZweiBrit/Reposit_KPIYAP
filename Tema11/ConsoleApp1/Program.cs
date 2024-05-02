using System;

class Car
{
    protected string brand;
    protected double speed;

    public Car(string brand, double speed)
    {
        this.brand = brand;
        this.speed = speed;
    }

    public virtual double FuelConsumption()
    {
        return 0; 
    
    }

    
    public virtual void DisplayResults()
    {
        Console.WriteLine("Brand: " + brand);
        Console.WriteLine("Speed: " + speed + " km/h");
    }
}


class Truck : Car
{
    private double cargoCapacity;

    public Truck(string brand, double speed, double cargoCapacity) : base(brand, speed)
    {
        this.cargoCapacity = cargoCapacity;
    }

    
    public override double FuelConsumption()
    {
        return Math.Sqrt(cargoCapacity) * 100;
    }

    
    public override void DisplayResults()
    {
        base.DisplayResults();
        Console.WriteLine("Cargo Capacity: " + cargoCapacity + " tons");
        Console.WriteLine("Fuel Consumption: " + FuelConsumption() + " liters/100 km");
    }
}


class PassengerCar : Car
{
    private double engineVolume;

    public PassengerCar(string brand, double speed, double engineVolume) : base(brand, speed)
    {
        this.engineVolume = engineVolume;
    }

    
    public override double FuelConsumption()
    {
        return 2.5 * engineVolume;
    }

    
    public override void DisplayResults()
    {
        base.DisplayResults();
        Console.WriteLine("Engine Volume: " + engineVolume + " cubic cm");
        Console.WriteLine("Fuel Consumption: " + FuelConsumption() + " liters/100 km");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Car[] cars = new Car[5];
        cars[0] = new Truck("Volvo", 80, 15);
        cars[1] = new PassengerCar("Toyota", 100, 2000);
        cars[2] = new Truck("MAN", 70, 12);
        cars[3] = new PassengerCar("Ford", 90, 1800);
        cars[4] = new PassengerCar("BMW", 120, 2500);

    
        foreach (Car car in cars)
        {
            Console.WriteLine("\nCar Details:");
            car.DisplayResults();
        }
    }
}
