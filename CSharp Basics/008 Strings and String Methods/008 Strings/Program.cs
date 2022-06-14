using System;

namespace _008_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Strings are referance types.
            //if you change a string value, it totally changes and it is written to another location
            //at the memory.
            string city = "İstanbul";
            string city2 = "Ankara";
            string sentence = "Murat Uğur KİRAZ";

            //first character
            Console.WriteLine(city[0]);

            //Adding a space
            Console.WriteLine(city + " " + city2);
            // Adding a space with format
            Console.WriteLine(String.Format("{0} {1}", city, city2));

            //How many characters a string has.
            Console.WriteLine(sentence.Length);

            //Clone methods clones sentence another address in the memory

            string sentence2 = (string)sentence.Clone();
            //Sentence2 does not change.
            Console.WriteLine(sentence2);
            //Returns true
            Console.WriteLine(sentence.StartsWith("M"));
            //Retuns false. Not case sensitive
            Console.WriteLine(sentence.StartsWith("m"));
            //Returns true
            Console.WriteLine(sentence.EndsWith("Z"));
            //Retuns false. Not case sensitive
            Console.WriteLine(sentence.EndsWith("z"));
            //return index number of a string
            Console.WriteLine(sentence.IndexOf('a'));

            //All of them capital
            Console.WriteLine(sentence.ToUpper());

            //All of them small

            Console.WriteLine(sentence.ToLower());






            Console.ReadKey();
        }
    }
}
