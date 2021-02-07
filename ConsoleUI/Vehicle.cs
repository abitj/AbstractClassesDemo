using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public abstract class Vehicle
    {
        public int Year { set; get; } = 1;
        public string Make { set; get; } = "Default Make";
        public string Model { set; get; } = "Default Model";

        public abstract void DriveAbstract();

        public virtual void DriveVirtual()
        {
            Console.WriteLine($"This {GetType().Name} is virtually in drive ");
        }
    }

    
    
}
