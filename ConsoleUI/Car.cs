using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Car : Vehicle
    {
        public Car()
        {

        }
        public bool HasTrunk { set; get; } = true;
        public override void DriveAbstract()
        {
            Console.WriteLine("This car in drive");
        }
    }
}
