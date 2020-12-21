using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifiers.Lib1
{
    public class Phone
    {
        private protected int ProductionYear = 2020;
        internal string Brand = "Apple";
        protected string OsVersion = "iOS 16.X";
        protected internal string Number = "0751-123.456";
        public string Color = "Gold";

        private void PrintDetailedInfo()
        {
            Console.WriteLine($"ProductionYear={ProductionYear}");
            Console.WriteLine($"Brand={Brand}");
            Console.WriteLine($"OsVersion={OsVersion}");
            Console.WriteLine($"Number={Number}");
            Console.WriteLine($"Color={Color}");
        }
    }
}
