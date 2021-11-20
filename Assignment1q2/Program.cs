using System;

namespace Assignment1q2
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Console.WriteLine("Hello World!");
            int num1;
            Console.WriteLine("enter the Month number:");
            num1 = Convert.ToInt32(Console.ReadLine());
            switch (num1)
            {
                case 1:
                    Console.WriteLine("we have 31 days");
                    break;

                case 2:
                    Console.WriteLine("we have 28 days");
                    break;
                case 3:
                    Console.WriteLine("we have 31 days ");
                    break;
                case 4:
                    Console.WriteLine("we have 30 days");
                    break;
                case 5:
                    Console.WriteLine("we have 31 days");
                    break;
                case 6:
                    Console.WriteLine("we have 30 days");
                    break;
                case 7:
                    Console.WriteLine("we have 31 days");
                    break;
                case 8:
                    Console.WriteLine("We have 31 days");
                    break;
                case 9:
                    Console.WriteLine("we have 30 days");
                    break;
                case 10:
                    Console.WriteLine("we have 31 days");
                    break;
                case 11:
                    Console.WriteLine("we have 30 days");
                    break;
                case 12:
                    Console.WriteLine("we have 31 days");
                    break;


            }
        }
    }
}
