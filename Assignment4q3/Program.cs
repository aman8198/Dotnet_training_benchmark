using System;

namespace Assignment4q3
{
    class Program
    {

        public static void Swap1(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            int x, y;
            Console.WriteLine("Enter 2 nos for swapping");
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Before swapping x ={0} y={1}", x, y);
            Swap1(ref x, ref y);
            Console.WriteLine("After swapping x={0} y={1} ", x, y);
            Console.ReadKey();

        }
    }
}
