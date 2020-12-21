using AccessModifiers.Lib1;
using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifiers.Lib2
{
    public class Car
    {
        public void DialWhileDriving()
        {
            Phone phone = new Phone();

            // Console.WriteLine($"ProductionYear={phone.ProductionYear}");
            // Console.WriteLine($"Brand={phone.Brand}");
            // Console.WriteLine($"OsVersion={phone.OsVersion}");
            // Console.WriteLine($"Number={phone.Number}");
            Console.WriteLine($"Color={phone.Color}");
        }
    }
}
