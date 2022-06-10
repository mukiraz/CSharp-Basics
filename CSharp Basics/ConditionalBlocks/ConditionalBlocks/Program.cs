using System;

namespace ConditionalBlocks
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = 10;
            // this is classical if block
            if (number == 10)
            {
                Console.WriteLine("The number is 10");
            }
            else if (number == 11)
            {
                Console.WriteLine("The number is 11");
            } 
            else
            {
                Console.WriteLine("The number is not 10 or 11");
            }

            // This is the short style of if condition :)

            Console.WriteLine(number == 10 ? "Number is 10" : "Number is not 10");


            // this is classical switch block

            switch (number)
            {
                case 10:
                    Console.WriteLine("The number is 10");
                    break;
                case 11:
                    Console.WriteLine("The number is 11");
                    break;

                default:
                    // the default block runs if no other condionals fit.
                    Console.WriteLine("The number is 10 or 11");
                    break;
            }

            Console.ReadKey();
        }
    }
}
