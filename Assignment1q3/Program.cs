using System;

namespace Assignment1q3
{
    class Program
    {
        class Employee
        {
            public string Name;
            public string Deisgnation;
            public int Salary;
            public int Code;
            public void setName(string name)
            {
                Name = name;
            }
            public void setDesignation(string designation)
            {
                Deisgnation = designation;
            }
            public void setSalary(int salary)
            {
                Salary = salary;
            }
            public void setCode(int code)
            {
                Code = code;
            }
            public string getName()
            {
                return Name;
            }
            public string getDesignation()
            {
                return Deisgnation;
            }
            public int getSalary()
            {
                return Salary;
            }
            public int getCode()
            {
                return Code;
            }
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            int Salary1;
            string Name1;
            string Designation1;
            int Code1;

            //Console.WriteLine("Hello World!");
            Employee e = new Employee();
            //e.setName("Aman Kumar Jha");
            e.setSalary(20000);
            //e.setDesignation("Software Engineer");
            //e.setCode(12334);
            e.setName("Aman ");
            e.setDesignation("Software Engineer");
            e.setCode(2398);
            Name1 = e.getName();
            Designation1 = e.getDesignation();
            Code1 = e.getCode();

            Salary1 = e.getSalary();
            Console.WriteLine("Salary: {0}", Salary1);
            Console.WriteLine("Name: {0}", Name1);
            Console.WriteLine("Designation: {0}", Designation1);
            Console.WriteLine("Code: {0}", Code1);


            Console.ReadKey();

        }
    }
}
