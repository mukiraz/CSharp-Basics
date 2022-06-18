using System;

namespace InterfaceUsage1
{
    class Program
    {
        static void Main(string[] args)
        {
            //We assume that we have 3 differnet databases.
            //These ate MySQL, Oracle, MSSQL
            //We will have same methods. Select(), Insert(),
            //Update(), Delete().
            //These methods will not be the same but they will make the same job.

            //First we created a new Interface File named as ICostumerDal.cs
            //This interface has these methods above.

            //Than We crated SqlServerCustomerDal, MySqlServerCustomerDal and OracleServerCustomerDal.
            //These three classes are implemented bı ICustomerDal interface. That means that these classes should have
            //Select(), Insert(), Update(), Delete() methods.

            //Then we created CustomerManager class. And that class takes ICustomerDal argument.
            //Here we created customerManager object.
            CustomerManager customerManager = new CustomerManager();

            //If I need to use add data to SQLServer:

            customerManager.Add(new SqlServerCustumerDal());

            //If I need to use add data to MySQLServer:

            customerManager.Add(new MySqlServerCustomerDal());

            //If I need to use add data to OracleServer:

            customerManager.Add(new OracleCustomerDal());

            //Scenerio: We want to update same data both MySqlServer, SQLServer, OracleServer

            ICustomerDal[] customerDals = new ICustomerDal[3]
            {
                new MySqlServerCustomerDal(),
                new OracleCustomerDal(),
                new SqlServerCustumerDal()
            };


            foreach (var customerDal in customerDals)
            {
                customerDal.Update();
            }

            Console.ReadKey();

        }
    }

    //
}
