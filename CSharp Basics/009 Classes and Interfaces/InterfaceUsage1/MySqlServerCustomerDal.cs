using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceUsage1
{
    class MySqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("MySQL Added");
        }

        public void Delete()
        {
            Console.WriteLine("MySQL Deleted");
        }

        public void Select()
        {
            Console.WriteLine("MySQL Selected");
        }

        public void Update()
        {
            Console.WriteLine("MySQL Updated");
        }
    }
}
