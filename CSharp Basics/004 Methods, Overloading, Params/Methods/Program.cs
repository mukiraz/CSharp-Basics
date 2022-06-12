using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Add();
            Add(50, 60);
            int factorial = Factorial(5);
            
            Console.WriteLine(factorial);
            Console.WriteLine("The sum of the numbers are: {0}", Add(1, 2, 3, 4, 5, 6, 7, 8, 9));
            Console.ReadKey();
        }

        // Without parameters
        static void Add()
        {
            Console.WriteLine("Added");
        }
        //With parameters.
        //This is the method overloading. We have to use the same method mane with different parameters.
        static void Add(int number1 = 20, int number2= 30)
        {
            int sum = number1 + number2;
            Console.WriteLine(sum);
        }

        static int Add(params int[] numbers)
        {
            int sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }
            return sum;
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
