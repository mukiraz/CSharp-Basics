using System;

namespace TypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            //These are value types
            // Integer is between -2147483648 and 2147483647
            int number1 = -2147483648;
            // Long in between -9223372036854775808 and 9223372036854775807
            long number2 = 9223372036854775807;
            //short is between -32768 and 32767
            short number3 = -32768;
            //byte is between 0 and 255
            byte number4 = 255;
            //boolean true, false
            bool boolean = true;
            // Char is connected with ASCII
            char character = 'A';
            //Double big float 64 bit
            double number5 = 10;
            //decimal 
            decimal number6 = 10.4m;
            //var is defined as first assigned type variable.
            var number7 = 10;
            //this code below will not work.
            // number7 = "String"
            //but this will work
            // number7 = 'A' because char has a value of integer in ASCII table
            Console.WriteLine("Number 1 is {0}",number1);
            Console.WriteLine("Number 2 is {0}", number2);
            Console.WriteLine("Number 3 is {0}", number3); 
            Console.WriteLine("Number 4 is {0}", number4);
            if (boolean)
            {
                Console.WriteLine("Bool value is true");
            }
            Console.WriteLine("The character is {0}", character);
            Console.WriteLine("Number 5 is {0}", number5);
            Console.WriteLine("Number 6 is {0}", number6);
            Console.WriteLine("Number 7 is {0}", number7);
            Console.ReadLine();
        }
    }
}
