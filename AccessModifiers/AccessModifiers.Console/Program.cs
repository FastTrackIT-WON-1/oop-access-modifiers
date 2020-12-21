using System;
using AccessModifiers.Lib1;
using AccessModifiers.Lib2;

namespace AccessModifiers.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //DialPhone phone = new DialPhone();
            //phone.Dial();

            Person p = new Person();
            p.CallAFriend();
        }
    }
}
