using System;

namespace InterfaceUsage2
{
    class Program
    {
        static void Main(string[] args)
        {
            //We have 3 different types of workers in a company.
            //These are Programmers, Managers and Robots.
            

            //We have IWork interface in all classes.

            IWork[] works = new IWork[3]
            {
                new Programmer(),
                new Manager(),
                new Robot(),
            };

            foreach (var work in works)
            {
                work.Work();
            }

            Console.WriteLine("********************");

            IEat[] eats = new IEat[2]
            {
                new Programmer(),
                new Manager()
            };

            foreach (var eat in eats)
            {
                eat.EatBreakfast();
            }

            Console.WriteLine("********************");

            Console.ReadKey();
        }
    }

    //We created an interface as IWorker
    //We will make something false with that.
    //Instead of doing that make little Interfaces!!!!
    //interface IWorker
    //{
    //    void Work();
    //    //Robots do not eat!!!!!!
    //    void Eat();
    //    //robots do not get salary!!!
    //    void GetSalary();
    //}

    interface IWork
    {
        void Work();
    }

    interface IEat
    {
        void EatBreakfast();
        void EatLunch();
        void EatDinner();
    }

    interface IAdministrativeWorks
    {
        void GetSalary();
        void GoVacation();
        void goHospital();
    }

    interface IDuty
    {
        void DoNotSleep();

        void GetSalary();
    }


    //class Manager : IWorker
    //{
    //    public void Eat()
    //    {
    //        Console.WriteLine("Manager Eated");
    //    }

    //    public void GetSalary()
    //    {
    //        Console.WriteLine("Manager Got his/her salary");
    //    }

    //    public void Work()
    //    {
    //        Console.WriteLine("Manager worked");
    //    }
    //}

    class Manager : IWork, IEat, IAdministrativeWorks
    {
        public void EatBreakfast()
        {
            Console.WriteLine("Manager ate breakfast");
        }


        public void EatDinner()
        {
            throw new NotImplementedException();
        }

        public void EatLunch()
        {
            throw new NotImplementedException();
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        public void goHospital()
        {
            throw new NotImplementedException();
        }

        public void GoVacation()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            Console.WriteLine("Manager worked");
        }
    }

    //class Programmer:IWorker
    //{
    //    public void Eat()
    //    {
    //        Console.WriteLine("Programmer Eated");
    //    }

    //    public void GetSalary()
    //    {
    //        Console.WriteLine("Programmer Got his/her salary");
    //    }

    //    public void Work()
    //    {
    //        Console.WriteLine("Programmer worked");
    //    }
    //}

    class Programmer : IAdministrativeWorks, IEat, IWork, IDuty
    {
        public void DoNotSleep()
        {
            throw new NotImplementedException();
        }

        public void EatBreakfast()
        {
            Console.WriteLine("Programmer ate breakfast");
        }

        public void EatDinner()
        {
            throw new NotImplementedException();
        }

        public void EatLunch()
        {
            throw new NotImplementedException();
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        public void goHospital()
        {
            throw new NotImplementedException();
        }

        public void GoVacation()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            Console.WriteLine("Programmer worked");
        }
    }

    //class Robot:IWorker
    //{
    //    //robot does not eat!
    //    public void Eat()
    //    {
    //        //Programmers comments or deletes inside of the class.
    //        //Do not do that.
    //        //Console.WriteLine("Robot Eated");
    //    }
    //    //robot does not get its salary!
    //    public void GetSalary()
    //    {
    //        //Console.WriteLine("Robot Got his/her salary");
    //    }

    //    public void Work()
    //    {
    //        Console.WriteLine("Programmer worked");
    //    }
    //}

    class Robot : IWork
    {
        public void Work()
        {
            Console.WriteLine("Robot worked");
        }
    }
}
