using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceUsage1
{
    class CustomerManager
    {
        //We created here an Add() method and this method takes ICustomerDal argument
        //So what does it mean?
        //We are not dependent to any database.

        public void Add(ICustomerDal customerDal)
        {
            customerDal.Add();
        }
    }
}
