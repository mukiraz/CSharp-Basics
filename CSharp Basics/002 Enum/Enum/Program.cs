using System;

namespace Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Days.Friday);
            Console.ReadKey();
        }

        //Enums are used for the constants that you do not need to change.
        enum Days
        {
            Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
        }

    }
}
