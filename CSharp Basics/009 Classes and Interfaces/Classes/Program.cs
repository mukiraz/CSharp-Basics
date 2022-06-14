using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();

            customerManager.Add();

            //We can create object like that
            Customer customer = new Customer();
            customer.Id = 1;
            customer.City = "Naters";
            customer.FirstName = "Murat Ugur";
            customer.LastName = "KİRAZ";

            //We can create object like that also

            Customer customer2 = new Customer
            {
                Id = 1, City = "Naters" , FirstName = "Murat Ugur", LastName = "KİRAZ"
            };

            Console.WriteLine(customer2.FirstName);

            Console.ReadKey();


        }
    }

    //Classes are used for creating objects.

    class CustomerManager
    {
        
        public void Add()
        {
            Console.WriteLine("Customer Added");
        }

        public void Update()
        {
            Console.WriteLine("Customer Updated");
        }

        public void Delete()
        {
            Console.WriteLine("Customer Deleted");
        }
    }

    class ProductManager
    {
        public void Add()
        {
            Console.WriteLine("Product Added");
        }

        public void Update()
        {
            Console.WriteLine("Product Updated");
        }

        public void Delete()
        {
            Console.WriteLine("Product Deleted");
        }
    }


    class Customer
    {
        //These properties are for encapsulation.

        //There is no different issue about writing like that
        //We define private variables in the scope begins with _
        private string _Address;

        public string Adress
        {
            //Here the get block returns the value of private variable
            get
            {
                return "The address is: "+ _Address;
            }

            //Here the set block sets the value of private variable
            set
            {
                _Address = value;
            }
        }
        //prop tab tab

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
