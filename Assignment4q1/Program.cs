using System;
using System.Collections.Generic;

namespace Assignment4q1
{
    class Employee
    {
        int empno;
        string ename, department;

        public Employee(int eno, string enm, string dept)
        {
            empno = eno;
            ename = enm;
            department = dept;
        }

        public Employee(int eno, string enm)
            : this(eno, enm, "Not Assigned")
        {

        }

        public override string ToString()
        {

            return "Empno " + empno + " Ename " + ename + " department " + department;
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            List<Employee> elist = new List<Employee>();
            elist.Add(new Employee(1, "Aman"));
            elist.Add(new Employee(2, "Aman1"));
            elist.Add(new Employee(3, "Aman2"));
            elist.Add(new Employee(4, "Aman3"));
            elist.Add(new Employee(5, "Aman4"));
            elist.Add(new Employee(6, "Aman5"));

            foreach (Employee e in elist)
            {
                Console.WriteLine(e);
            }

            Console.ReadKey();
        }
    }
}
