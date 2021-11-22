using System;
using System.Collections.Generic;

namespace Assignment4q2
{
    public class Employee
    {
        public int ID;
        public string name;
        public string Address;
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Employee e = new Employee();
            List<Employee> emp = new List<Employee>();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter ID:");
                e.ID = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Name:");
                e.name = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Enter Address:");
                e.Address = Convert.ToString(Console.ReadLine());
                emp.Add(e);
                Console.WriteLine("Details below");
                Console.WriteLine(e.ID);
                Console.WriteLine(e.name);
                Console.WriteLine(e.Address);
                Console.WriteLine();

            }
           
            Console.Read();
        }
    }
}