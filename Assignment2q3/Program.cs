using System;

namespace Assignment2q3
{
    public class EmpArray
    {
        int eid;
        string name;
        double salary;
        public EmpArray()
        {
            eid = 0;
            name = "xyz";
            salary = 1000;
        }

        public void accept()
        {
            Console.WriteLine("Enter employee Id: ");
            eid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter Salary: ");
            salary = Convert.ToDouble(Console.ReadLine());
        }

        public void Display()
        {
            Console.WriteLine("Employee details: ");
            Console.WriteLine(name + " " + eid + " " + salary);
            Console.WriteLine();


        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            // Console.WriteLine("Hello World!");
            Console.WriteLine("Enter the number of employee ");
            int n = Convert.ToInt32(Console.ReadLine());
            int i;
            EmpArray[] ob = new EmpArray[n];
            for (i = 0; i < n; i++)
            {
                ob[i] = new EmpArray();
                ob[i].accept();
                ob[i].Display();
            }
            Console.ReadLine();
        }
    }
}
