using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceUsage1
{
    class SqlServerCustumerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("SQL Added");
        }

        public void Delete()
        {
            Console.WriteLine("SQL Deleted");
        }

        public void Select()
        {
            Console.WriteLine("SQL Selected");
        }

        public void Update()
        {
            Console.WriteLine("SQL Updated.");
        }
    }
}
