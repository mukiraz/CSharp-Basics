using System;

namespace _007_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //ForLoop(0, 10, 2);
            //WhileLoop(0,10,2);
            //DoWhileLoop(0, 10);
            //ForeachLoop(0, 10,2);
            isPrime(27);
            isPrime(2);
            isPrime(0);
            isPrime(-52);
            isPrime(5);
            isPrime(7);
            isPrime(11);
            isPrime(3);

            Console.ReadKey();
        }

        private static void DoWhileLoop(int numberStart, int numberEnd, int increment = 1)
        {
            do
            {
                Console.WriteLine("Do while loop number: {0}", numberStart);
                numberStart += increment;
            } while (numberStart <= numberEnd);
            Console.WriteLine("DoWhile loop Finished");
        }

        private static void WhileLoop(int numberStart, int numberEnd, int increment = 1)
        {
            
            while (numberStart <= numberEnd)
            {
                Console.WriteLine("While loop number: {0}", numberStart);
                numberStart += increment;
            }
            Console.WriteLine("While loop Finished");
        }

        private static void ForLoop(int numberStart, int numberEnd, int increment = 1)
        {
            for (int i = numberStart; i <= numberEnd; i+= increment)
            {
                Console.WriteLine("For loop number: {0}", i);
            }
            Console.WriteLine("For loop Finished");
        }

        private static void ForeachLoop(int numberStart, int numberEnd, int increment = 1)
        {
            int count = ((numberEnd - numberStart) / increment)+1;
            int[] numbers = new int[count];
            int k = 0;
            for (int i = numberStart; i <= numberEnd; i += increment)
            {
                numbers[k] = i;
                k++;
            }

            foreach (var number in numbers)
            {
                Console.WriteLine("ForEach loop number: {0}", number);
            }
            Console.WriteLine("ForEach loop Finished");
        }

        private static void isPrime(int number)
        {
            bool isPrime = true;
            if (number <=0)
            {
                isPrime =false;

            } else if (number == 1 || number ==2)
            {
                isPrime = true;
            } 
            else
            {
                for (int i = 3; i < (number / 2 + 1); i++)
                {
                    if (number % i == 0)
                    {
                        isPrime = false;
                        break;
                    }

                }

            }

            if (isPrime)
            {
                Console.WriteLine("{0} is a prime number", number);
            }
            else
            {
                Console.WriteLine("{0} is not a prime number", number);
            }
        }
    }
}
