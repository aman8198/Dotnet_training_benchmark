using System;

namespace Assignment3q2
{
    interface IPrintable
    {
        void name();
        void relation();
        void amount();
    }
    class Account : IPrintable
    {
        public void name()
        {
            Console.WriteLine(" My name is Account");
        }

        public void relation()
        {
            Console.WriteLine(" I am present in a bank");
        }

        public void amount()
        {
            Console.WriteLine("Amount is saved in me");
        }
    }

    class Employee : IPrintable
    {
        public void name()
        {
            Console.WriteLine(" My name is Employee");
        }

        public void relation()
        {
            Console.WriteLine(" I am present in a company");
        }

        public void amount()
        {
            Console.WriteLine("Amount is earned by me");
        }

    }

    class Program
    {

        public void display(IPrintable i)
        {
            i.name();
            i.relation();
            i.amount();
        }
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            Program p = new Program();
            Account s = new Account();
            Employee e = new Employee();

            p.display(e);
            p.display(s);
        }
    }
}
