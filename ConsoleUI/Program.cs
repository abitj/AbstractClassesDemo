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
            
            #region Vehicles

            /*
             * DONE---Create an abstract class called Vehicle
             * DONE---The vehicle class shall have three string properties Year, Make, and Model
             * DONE--- Set the defaults to something generic in the Vehicle class
             * DONE---Vehicle shall have an abstract method called DriveAbstract with no implementation
             * DONE---Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */


            /* DONE---
             * DONE---Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * DONE---Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * DONE---Provide the implementations for the abstract methods
             * DONE---Only in the Motorcycle class will you override the virtual drive method
            */

            /*
             * DONE--- Create a list of Vehicle called vehicles
             *DONE--- Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             *DONE--- new it up as one of each derived class
             *DONE---Set the properties with object initializer syntax  
             *DONE--- Add the 4 vehicles to the list
             *DONE---  Using a foreach loop iterate over each of the properties
             *DONE-- - Call each of the drive methods for one car and one motorcycle
              */

            var vehicles = new List<Vehicle>();
            Car focus = new Car() { HasTrunk = true, Make = "Jeep", Model = "Wrangler", Year = 2021 };
            Motorcycle senke = new Motorcycle() { HasSideCart = false, Make = "Senke", Model = "Boda", Year = 2020, };

            Vehicle camry = new Car() { HasTrunk = false, Make = "Toyota", Model = "Camry", Year = 2009, };
            Vehicle dodge = new Car() { Make = "Dodge", Model = "Sedan", Year = 2006, };
         
            vehicles.Add(dodge);
            vehicles.Add(camry);
            vehicles.Add(senke);
            vehicles.Add(focus);
            
            foreach(var veh in vehicles)
            {
                Console.WriteLine($"Make: { veh.Make}, Model: { veh.Model}, Year: { veh.Year}. ");
                veh.DriveAbstract();
                Console.WriteLine("----------------------------------------");
            }
            #endregion
            Console.ReadLine();
        }
    }
}
