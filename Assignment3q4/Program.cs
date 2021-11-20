using System;

namespace Assignment3q4
{
    class DivByZero : Exception
    {
        public DivByZero()
        {
            Console.Write("Exception has occured :");
        }
    }
    class Program
    {
        public double DivisionOperation(double numerator, double denominator)
        {
            if (denominator == 0)
                throw new DivByZero();
            return numerator / denominator;
        }
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            Program obj = new Program();
            double num = 9, den = 0, quotient;
            try
            {
                quotient = obj.DivisionOperation(num, den);
                Console.WriteLine("Quotient = {0}", quotient);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
