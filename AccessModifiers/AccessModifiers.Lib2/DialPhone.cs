using AccessModifiers.Lib1;
using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifiers.Lib2
{
    public class DialPhone : Phone
    {
        public void Dial()
        {
            // Console.WriteLine($"Dialing from land line phone {Brand}");


            // Console.WriteLine($"ProductionYear={ProductionYear}");
            // Console.WriteLine($"Brand={Brand}");
            Console.WriteLine($"OsVersion={OsVersion}");
            Console.WriteLine($"Number={Number}");
            Console.WriteLine($"Color={Color}");


        }
    }
}
