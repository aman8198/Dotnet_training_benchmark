using System;

namespace Assignment2q1
{
    class Student
    {
        private double Marks;
        public double getMarks()
        {
            return Marks;
        }
        public void setMarks(double marks)
        {
            Marks = marks;
        }
        public static Student operator
            +(Student a, Student b)
        {
            Student s = new Student();
            s.Marks = a.Marks + b.Marks;
            return s;
        }
        public static Student operator -(Student d, Student e)
        {
            Student c = new Student();
            c.Marks = d.Marks - e.Marks;
            return c;
        }

        public static bool operator ==(Student f, Student g)
        {
            if (f.Marks == g.Marks)
                return true;
            else
                return false;

        }

        public static bool operator !=(Student f1, Student g1)
        {
            if (f1.Marks != g1.Marks)
                return true;
            else
                return false;
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            // Console.WriteLine("Hello World!");
            Student s1 = new Student();
            Student s2 = new Student();
            Student s3 = new Student();
            Double m;

            s1.setMarks(20.00);
            s2.setMarks(30.00);

            m = s1.getMarks();
            Console.WriteLine("First Student marks: {0}", m);

            m = s2.getMarks();
            Console.WriteLine("Second Student Marks: {0}", m);

            s3 = s1 + s2;

            m = s3.getMarks();
            Console.WriteLine("Sum of both marks: {0}", m);

            s3 = s1 - s2;

            m = s3.getMarks();
            Console.WriteLine("difference of both marks: {0}", m);
            if (s1 == s2) { Console.WriteLine("object equal"); }
            else { Console.WriteLine("Not equal"); }
            Console.ReadKey();
        }
    }
}
