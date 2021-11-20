using System;

namespace Assignment3q6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            //
            //Console.WriteLine("Hello World!");
            int[] arr = { 1, 3, 2, 4, 5 };
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            try
            {
                Console.WriteLine(arr[7]);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("An Exception has occured : {0}", e.Message);
            }
        }
    }
}
