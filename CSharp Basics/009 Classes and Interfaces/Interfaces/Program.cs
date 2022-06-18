using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonManager personManager = new PersonManager();


            personManager.Add(new Customer { Id = 1, Name = "Murat Ugur", Surname = "KİRAZ", Address = "Naters" });

            personManager.Add(new Student { Id = 1, Name = "Michael", Surname = "Dunlop", ClassNumber = "123456" });
            //You can not crete an object from an Interface.

            //This code below will not work.
            //IPerson person = new IPerson();

            //However you can create an object from a class
            //using that interface.

            IPerson customer = new Customer();

            customer.Name = "Mehmet";

            Console.WriteLine(customer.Name);

            
            Console.ReadKey();
        }
    }

    //An interface is an abstract object. You can not create an object
    //from an interface. The properties and methods are defined in the
    //interface. And this interfaces are appplied to the classes.

    interface IPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }   
    }

    class Customer : IPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public string Address { get; set; }
    }

    class Student:IPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public string ClassNumber { get; set; }

    }

    class PersonManager
    {
        //Here we define Iperson interface to the
        //Add method. So ıt will take customer or
        //student class as parameter.

        //public void Add(Customer customer) =>Here only takes customer
        public void Add(IPerson person)
        {
            Console.WriteLine(person.Name + " " + person.Surname + " Added!");
        }

    }
}
