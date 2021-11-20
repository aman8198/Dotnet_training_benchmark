using System;

namespace Assignment1q1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            int num1 = 0, num2 = 1, num3, i, num4;
            Console.WriteLine("Enter number of elements:");
            num4 = Convert.ToInt32(Console.ReadLine());
            for (i = 2; i < num4; i++)
            {
                num3 = num1 + num2;
                Console.WriteLine("{0}", num3);
                num1 = num2;
                num2 = num3;
            }
        }
    }
}
