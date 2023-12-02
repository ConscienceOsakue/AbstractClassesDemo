using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        public bool HasSideCart { get; set; }
        public override void DriveAbstract()
        {
            Console.WriteLine("The motorcycle is driving ..");

        }

        public override void DriveVirtual()
        {
            Console.WriteLine("The motorcycle virtual driving ..");
        }
    }
}
