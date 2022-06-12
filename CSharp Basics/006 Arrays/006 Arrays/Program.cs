using System;

namespace _006_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating Arrays:

            // We can create our array like that
            string[] students = new string[3];

            students[0] = "Alice";
            students[1] = "Bob";
            students[2] = "Charlie";



            ShowStringElements(students);

            //Or like this

            int[] numbers = new int[8]
            {
                1,2,3,4,5,6,7,8
            };

            ShowIntElements(numbers);

            string[,] regions = new string[5, 3]
            {
                {"İstanbul", "İzmit","Balıkesir"},
                {"Ankara", "Konya","Kırıkkale"},
                {"Antalya", "Adana","Mersin"},
                {"Rize", "Trabzon","Samsun"},
                {"İzmir", "Muğla","Manisa"}
            };

            ShowRegions(regions);

            Console.ReadKey();


        }

        static void ShowStringElements(string[] elements)
        {
            foreach (string element in elements)
            {
                Console.WriteLine(element);
            }
        }

        static void ShowIntElements(int[] elements)
        {
            foreach (var element in elements)
            {
                Console.WriteLine(element);
            }
        }

        static void ShowRegions(string[,] regions)
        {
            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i, j]);
                }

                Console.WriteLine("******");

            }
        }


    }
}
