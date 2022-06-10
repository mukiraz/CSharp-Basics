using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Add();
            Add2(50, 60);
            int factorial = Factorial(5);
            Console.WriteLine(factorial);
            Console.ReadKey();
        }

        // Without parameters
        static void Add()
        {
            Console.WriteLine("Added");
        }

        static void Add2(int number1 = 20, int number2= 30)
        {
            int sum = number1 + number2;
            Console.WriteLine(sum);
        }

        // This is a recursive method
        static int Factorial(int n)
        {
            if (n <= 1)
            {
                return 1;
            }

            return n * Factorial(n - 1);
        }
    }
}
