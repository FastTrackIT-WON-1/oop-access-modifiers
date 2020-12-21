using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifiers.Lib1
{
    public class Person
    {
        public void CallAFriend()
        {
            Phone phone = new Phone();
            Console.WriteLine($"Calling a friend using");

            // Console.WriteLine($"ProductionYear={phone.ProductionYear}");
            Console.WriteLine($"Brand={phone.Brand}");
            // Console.WriteLine($"OsVersion={phone.OsVersion}");
            Console.WriteLine($"Number={phone.Number}");
            Console.WriteLine($"Color={phone.Color}");
        }
    }
}
