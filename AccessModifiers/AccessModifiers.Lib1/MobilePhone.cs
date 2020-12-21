using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifiers.Lib1
{
    public class MobilePhone : Phone
    {
        public void PrintAboutMenu()
        {
            Console.WriteLine($"ProductionYear={ProductionYear}");
            Console.WriteLine($"Brand={Brand}");
            Console.WriteLine($"OsVersion={OsVersion}");
            Console.WriteLine($"Number={Number}");
            Console.WriteLine($"Color={Color}");
        }
    }
}
