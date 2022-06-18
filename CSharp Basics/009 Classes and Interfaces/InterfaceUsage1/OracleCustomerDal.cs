using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceUsage1
{
    class OracleCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle Added");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle Deleted");
        }

        public void Select()
        {
            Console.WriteLine("Oracle Selected");
        }

        public void Update()
        {
            Console.WriteLine("Oracle Updated");
        }
    }
}
