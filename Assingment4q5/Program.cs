using System;
using System.Collections.Generic;

namespace Assingment4q5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Dictionary<int, string> etab = new Dictionary<int, string>();
            etab.Add(1, "Aman");
            etab.Add(2, "Dhanashree");
            etab.Add(3, "Priyanka");
            etab.Add(4, "Ajinkya");



            foreach (KeyValuePair<int, string> de in etab)
            {
                Console.WriteLine(de.Key + " " + de.Value);
            }


            Console.ReadKey();
        }
    }
}
