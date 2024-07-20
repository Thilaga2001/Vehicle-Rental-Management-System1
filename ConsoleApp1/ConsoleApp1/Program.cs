using System;
using System.Diagnostics;
using System.Runtime.ConstrainedExecution;

public class Program
{
    public static void Main()
    {
        RentalAgency agency = new RentalAgency();

        Car car = new Car("Model S", "Tesla", 2022, 150m, 5, "Electric", "Automatic", true);
        Truck truck = new Truck("F-150", "Ford", 2021, 120m, 1000, "Pickup", true);
        Motorcycle motorcycle = new Motorcycle("Model 280", "KTM", 2023, 90m, 600, "Petrol", true);

        agency.AddVehicle(car);
        agency.AddVehicle(truck);
        agency.AddVehicle(motorcycle);

        Console.WriteLine("Fleet details:");
        agency.DisplayFleet();

        agency.RentVehicle(car);

        Console.WriteLine("\nFleet details after renting a car:");
        agency.DisplayFleet();

        Console.WriteLine($"\nTotal Revenue: {agency.TotalRevenue}");
    }
}
