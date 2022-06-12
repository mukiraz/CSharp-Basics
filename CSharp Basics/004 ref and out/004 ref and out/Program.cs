using System;

namespace _004_ref_and_out
{
    class Program
    {
        static void Main(string[] args)
        {

            int number1 = 10;
            int number2 = 20;
            //Here (Console.WriteLine(Add(number1, number2));) we will find the solution 50,
            //We will send 10 and 20 as parameters. These are value types.
            //Here in static void Main(string[] args) scope, the  number1 variable and in the scope of static int Add(int number1, int number2) number1 will not be in the same address in the memory.
            //In  Add() function, number1 variable will be created again in the memory. The 30 value will be assigned and the function will return 30 + number2 and 30+20.
            //Because of this, the result will be 50.
            Console.WriteLine("The Add function value is {0}", Add(number1, number2));
            //Here the number1 will not be 30. It will be 10
            Console.WriteLine("Value of number1 is {0}", number1);

            //We send number1 with ref keyword. It is the refecence of the address.
            //If we use ref keyword, we have to assign a value of number1.
            //The code should not be like this:


            //int number1;
            //int number2 = 20;
            //Addref(ref number1, number2);

            //This will give error.
            Console.WriteLine("The Addref function value is {0}", Addref(ref number1, number2));
            //Here the number1 will not be 10. It will be 30 because we sent the memory address of number 1 in the main scope.
            // Addref() function will change the value of number1. And it will be 30.
            Console.WriteLine("Value of number1 is {0}", number1);

            //out keyword makes the same process with the ref keyword,
            //The main difference is you may not assign the initial value.
            //int number1;
            //int number2 = 20;
            //Addref(ref number1, number2);

            //This will not give an error.

            int number3;
            Console.WriteLine("The Addref function value is {0}", Addout(out number3, number2));
            Console.WriteLine("Value of number3 is {0}", number3);
            Console.ReadKey();
        }

        //This method adds two numbers. 
        static int Add(int number1, int number2)
        {

            number1 = 30;
            return number1 + number2;
        }

        static int Addref(ref int number1, int number2)
        {
            // Here the number1 variable in the main scope and in this scope will be exactly the same because they will show the same
            number1 = 30;
            return number1 + number2;
        }

        static int Addout(out int number3, int number2)
        {
            // We have to set number3 variable here once.
            number3 = 30;
            return number3 + number2;
        }
    }
}
