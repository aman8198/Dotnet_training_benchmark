using System;

namespace Assignment1q5
{
    class Employee
    {
        public int empno;
        public string ename;
        public string designation;
        public int salary;

        public void acceptdetails()
        {
            Console.WriteLine("Enter emp no:");
            empno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter employee name:");
            ename = Console.ReadLine();
            Console.WriteLine("Enter designation:");
            designation = Console.ReadLine();
            Console.WriteLine("enter salary:");
            salary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("press enter after entering details");

        }
        public void getDetails()
        {
            Console.WriteLine("emp no: {0}", empno);
            Console.WriteLine("emp name: {0}", ename);
            Console.WriteLine("emp desination: {0}", designation);
            Console.WriteLine("emp salary: {0}", salary);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Employee e = new Employee();
            for (int i = 0; i < 10; i++)
            {
                e.acceptdetails();
                e.getDetails();
            }
        }
    }
}
