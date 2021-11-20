using System;

namespace Assignment3q1
{

    abstract class Account
    {
        public abstract void Interest();
    }
    class Saving : Account
    {
        public override void Interest()
        {
            Console.WriteLine("Enter the Amount For Saving:");
            double amount = Convert.ToDouble(Console.ReadLine());
            double interest = 0.12 * amount;
            Console.WriteLine(" The interest on your Saving amount: {0}", interest);

        }
    }
    class Current : Account
    {
        public override void Interest()
        {
            Console.WriteLine("Enter the Amount For Current:");
            double amount = Convert.ToDouble(Console.ReadLine());
            double interest = 0.14 * amount;
            Console.WriteLine(" The interest on your Saving amount: {0}", interest);
        }

    }

    class FD : Account
    {
        public override void Interest()
        {
            Console.WriteLine("Enter the Amount For FD:");
            double amount = Convert.ToDouble(Console.ReadLine());
            double interest = 0.16 * amount;
            Console.WriteLine(" The interest on your Saving amount: {0}", interest);

        }
    }
    class Program
    {
        public void FindInterest(Account a)
        {
            a.Interest();
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            //Console.WriteLine("Hello World!");
            Program p = new Program();
            Current c = new Current();
            Saving s = new Saving();
            FD f = new FD();
            p.FindInterest(s);
            p.FindInterest(c);
            p.FindInterest(f);
            Console.ReadKey();

        }
    }
}
