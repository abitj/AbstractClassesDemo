﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        public Motorcycle()  
        {   
        }

        public bool HasSideCart { set; get; } = false;
        public override void DriveAbstract()
        {
            Console.WriteLine("This motorcycle is not in drive");
        }
        public override void DriveVirtual()
        {
            Console.WriteLine($"This {GetType().Name}is a {GetType().BaseType.Name} that is virtually in drive ");

        }
    }
}