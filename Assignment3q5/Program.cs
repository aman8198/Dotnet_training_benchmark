using System;

namespace Assignment3q5
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Console.WriteLine("Hello World!");
            // Console.WriteLine("Hello World!");
            int[] arr = { 19, 0, 72, 52 };
            try
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine(arr[i] / arr[i + 1]);

                }

            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("An Exception has occured: {0}", e.Message);

            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("An Exception has occured: {0}", e.Message);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("An Exception has occured: {0}", e.Message);
            }
            finally
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine("{0}", arr[i]);
                }
            }
        }
    }
}
