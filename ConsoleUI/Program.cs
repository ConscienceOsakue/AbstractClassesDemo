using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*
             *Done - Create an abstract class called Vehicle
             *Done - The vehicle class shall have three string properties Year, Make, and Model
             * Done - Set the defaults to something generic in the Vehicle class
             * Done - Vehicle shall have an abstract method called DriveAbstract with no implementation
             * Done - Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * Done - Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Done - Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             *Done - Provide the implementations for the abstract methods
             * Done - Only in the Motorcycle class will you override the virtual drive method
            */

            // Done - Create a list of Vehicle called vehicles
            var vehicles = new List<Vehicle>();

            /*
             * Done - Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * Done - set them up as one of each derived class
             *Done - Set the properties with object initializer syntax
             */
            var car1 = new Car()
            {
                HasTrunk = true,
                Year = "2000",
                Make = "Honda",
                Model = "Accord",
            };

            var motorcycle1 = new Motorcycle() 
            { 
                HasSideCart = true,
                Year = "2001",
                Make = "Kawazik",
                Model = "Ninja",
            };
            
            Vehicle vehicle1 = new Car()
            { 
                Year = "2023",
                Make = "Tesla",
                Model = "X",
            };
            Vehicle vehicle2 = new Motorcycle() 
            {
                Year = "2010",
                Make = "Suzuki",
                Model = "GSXR",
            };

            /*
             * Done - Add the 4 vehicles to the list
             * Done - Using a foreach loop iterate over each of the properties
             */
            vehicles.Add(car1);
            vehicles.Add(motorcycle1);
            vehicles.Add(vehicle1);
            vehicles.Add(vehicle2);

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"Year: {vehicle.Year}");
                Console.WriteLine($"Model: {vehicle.Model}");
                Console.WriteLine($"Make: {vehicle.Make}");
                Console.WriteLine();
                vehicle.DriveVirtual();
                vehicle.DriveAbstract();
                Console.WriteLine();
            }

            // Done - Call each of the drive methods for one car and one motorcycle

            #endregion            
        }
    }
}
