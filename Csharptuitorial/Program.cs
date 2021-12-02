using System;

namespace Csharptuitorial
{
    /* for syntax part
    class Rectangle
    {
        double length;
        double width;
        public void Acceptdetails()
        {
            length = 4.5;
            width = 3.5;

        }

        public double GetArea()
        {
            return length * width;

        }

        public void Display()
        {
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Width: {0} ", width);
            Console.WriteLine("Area: {0}", GetArea());

        }

    }*/


    /*
    //public Access Specifier

    class Sum
    {
        public double a;
        public double b;

        public double GetResult()
        {
            return a + b;
        }

        public void Display()
        {
            Console.WriteLine(" value of a: {0} ", a);
            Console.WriteLine(" value of b: {0}", b);
            Console.WriteLine("Sum is: {0}", GetResult());
        }
    }
 */

    /*
    //private Access Specifier
    class Sum
    {
        private double a;
        private double b;
        public void AcceptDetails()
        {
            Console.WriteLine("Enter Number1: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Number2: ");
            b = Convert.ToDouble(Console.ReadLine());

        }

        public double GetSum()
        {
            return a + b;
        }

        public void Display()
        {
            Console.WriteLine("Number1: {0}", a);
            Console.WriteLine("Number2: {0}", b);
            Console.WriteLine("Sum: {0}", GetSum());
        }

    }
    */
    /*
    //internal Access Specifier
    class Sum
    {
        internal double a;
        internal double b;

        double GetSum()
        {
            return a + b;
        }

        public void Display()
        {
            Console.WriteLine("Number1: {0}", a);
            Console.WriteLine("Number2: {0}", b);
            Console.WriteLine("Sum:{0}", GetSum());
        }
    }
    */

    /*
    //methods
    class Number
    {
        public int FindMax(int num1, int num2)
        {
            int result;
            if (num1 > num2)
                result = num1;
            else
                result = num2;

            return result;
        }
    }
    */
    /*
    //methods Recursive Method call
    class Manipulator
    {
        public int factorial(int num)
        {
            int result;
            if (num == 1)
            {
                return 1;
            }
            else
            {
                result = factorial(num - 1) * num;
                return result;
            }

        }
    }
    */

    /*
    //structures
    struct Books
    {
        public string title;
        public string author;
        public string subject;
        public int book_id;
    };
    */
    /*
    //methods in structure 
    struct Books
    {
        public string title;
        public string author;
        public string subject;
        public int book_id;

        public void getValues(string t, string a, string s, int id)
        {
            title = t;
            author = a;
            subject = s;
            book_id = id;

        }

        public void display()
        {
            Console.WriteLine("Title: {0}", title);
            Console.WriteLine("Author: {0}", author);
            Console.WriteLine("Subject: {0}", subject);
            Console.WriteLine("Book_id: {0}", book_id);

        }
    };
    */
    /*
    //enumeration
    enum Days { Sun, Mon, tue, Wd, thu, Fri, Sat };
    */
    /*
    //classes
    class Box
    {
        public double length;
        public double breadth;
        public double height;

    }*/
    /*
    //member functiona and encapsulation
    class Box
    {
        public double length;
        public double breadth;
        public double height;

        public void setLength( double len)
        {
            length = len;
        }
        public void setHeight(double hei)
        {
            height = hei;
        } 
        public void setBreadth(double bre)
        {
            breadth = bre;
        }

        public double getVolume()
        {
            return length * breadth * height;
        }
    }

    //constructors
    class Line
    {
        private double length; //length of a file 
        public Line()
        {
            Console.WriteLine("object is being created");
        }
        public void setLength(double len)
        {
            length = len;
        }
        public double getLength()
        {
            return length;
        }

    }
    //parameterized Constructor
    class Line1
    {
        private double len;
        public Line1(double le)
        {
            Console.WriteLine("Object is being created, length = {0}", le);
            len = le;
        }

        public void setLength(double le)
        {
            len = le;
        }
        public double getLength()
        {
            return len;
        }
    }
    */
    /*
    //destructors
    class Line
    {
        private double length;

        public Line()
        {
            Console.WriteLine("Object is being created");
        }
        ~Line()
        {
            Console.WriteLine("object is being deleted");

        }

        public void setLength(double len)
        {
            length = len;
        }

        public double getLength()
        {
            return length;
        }

    }
    */
    /*
    //static members of a c# class
    class StaticVar
    {
        public static int num;

        public void count()
        {
            num++;
        }
        public int getNum()
        {
            return num;
        }
    }
    */
    /*Inheritance
    class Shape
    {
        protected int width;
        protected int height;
        public void setWidth(int w)
        {
            width = w;
        }
        public void setHeight(int h)
        {
            height = h;
        }

    }
    class Rectangle : Shape
    {
        public int getArea()
        {
            return (width * height);
        }
    }
    */
    /*
    //Initializing Base Class
    class Rectangle
    {
        protected double length;
        protected double width;
        public Rectangle(double l, double w)
        {
            length = l;
            width = w;

        }
        public double GetArea()
        {
            return length * width;
        }

        public void display()
        {
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area: {0}", GetArea());
        }
    }
    class Tabletop : Rectangle
    {
        public double cost;
        public Tabletop(double l, double w) : base(l,w) { }

        public double GetCost()
        {
            double cost;
            cost = GetArea() * 70;
            return cost;
        }
        public void display()
        {
            base.display();
            Console.WriteLine("Cost : {0}", GetCost());

        }

    }
    */
    /*
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

    }*/
    class Employee
    {
        public string Name
        {
            get;
            set;
        }
        public string Designation
        {
            get;
            set;
        }
        public int Salary
        {
            get; set;

        }
        public int Code
        {
            get; set;
        }
        public Employee(string name, string designation, int salary, int code)
        {
            Name = name;
            Designation = designation;
            Salary = salary;
            Code = code;

        }
        public string EmpDetails()
        {
            return Name;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            //  Console.WriteLine("Hello World!");
            /* syntax part
            Rectangle r = new Rectangle();
            r.Acceptdetails();
            r.Display();
            Console.ReadLine();
            */

            /*
            //data types part
            Console.WriteLine("Size of int: {0}", sizeof(int));
            Console.WriteLine("size o byte: {0}", sizeof(byte));
            Console.WriteLine("size of  double:{0}", sizeof(double));
            Console.WriteLine("size of float:{0}", sizeof(float));
            Console.WriteLine("size of long: {0}", sizeof(long));
            Console.WriteLine("size of sbyte:{0}", sizeof(sbyte));
            Console.WriteLine(" size of short: {0}", sizeof(short));
            */

            //type conversion are of two types explicit conversion and implicit conversion
            /*
            //explicit conversion
            double d = 675.98;
            int i;

            i = (int)d;
            Console.WriteLine(i);
            */
            /*
            //implicit type conversion
            int i = 75;
            float f = 53.005f;
            double d = 23452.908;
            bool b = true;
            Console.WriteLine(i.ToString());
            Console.WriteLine(f.ToString());
            Console.WriteLine(d.ToString());
            Console.WriteLine(b.ToString());
            Console.ReadLine();
            */

            /*
            //variable
            //declaring and initializing variable
            short a;
            int b;
            double c;

            a = 10;
            b = 20;
            c = a + b;
            Console.WriteLine(" a = {0}, b = {1}, c = {2}", a, b, c);
            Console.ReadLine();
            */

            /*
            //Accepting value of user
            Console.WriteLine("enter the number");
            int num;
            num = Convert.ToInt32(Console.ReadLine());

            Console.ReadLine();
            */


            //constant and literals
            /*
            //Following is the example to show few escape sequence characters
            Console.WriteLine("Hello\tWorld\n\n ");
            Console.ReadLine();
            */

            /*
            // following program demonstrates defining and using a constant in your program

            const double pi = 3.14159;
            double r;
            Console.WriteLine("Enter Radius: ");
            r = Convert.ToDouble(Console.ReadLine());
            double areaCircle = pi * r * r;
            Console.WriteLine("Radius: {0}, Area: {1}", r, areaCircle);
            Console.ReadLine();
            */
            //for operators revise theory 


            /*
            // decision making
            Console.WriteLine("enter the number");
            int num;
            num = Convert.ToInt32(Console.ReadLine());

            if(num%2 == 0)
            {
                Console.WriteLine("entered number is even");
            }
            else
            {
                Console.WriteLine("Number is odd");
            }
            Console.ReadLine();
            */
            /*
            //loops
            for(int i = 0; i<5; i++)
            {
                Console.WriteLine("Hey there");
            }
            */
            //encapsulation Encapsulation is implemented by using access specifiers. An access specifier defines the scope and visibility of a class member. C# supports the following access specifiers −
            /*
            Public
            Private
           Protected
           Internal
           Protected internal
            */

            /*
            //public Access Specifier

            Sum s = new Sum();
            s.a = 10;
            s.b = 23;
            s.Display();
            Console.ReadLine();
            */

            /*
            Sum s = new Sum();
            s.AcceptDetails();
            s.Display();
            Console.ReadLine();
            */
            /*
            Sum s = new Sum();
            s.a = 11.23;
            s.b = 23.4;
            s.Display();
            Console.ReadLine();

            */

            /*
            //method
            int a = 23;
            int b = 34;

            int res;
            Number n = new Number();
            res = n.FindMax(a, b);
            Console.WriteLine("Max Value is: {0}", res);
            Console.ReadLine();
            */
            /*
            //recursive Method call
            Manipulator m = new Manipulator();
            Console.WriteLine("Factorial of 8 is : {0}", m.factorial(8));
            Console.WriteLine("Factorial of 9 is: {0}", m.factorial(9));
            Console.ReadLine();
            */
            /*
            //nullable
            int? num1 = null;
            int? num2 = 45;

            double? num3 = new double?();
            double? num4 = 3.14;

            bool? boolval = new bool?();

            //display the values
            Console.WriteLine(" Nullables at Show: {0}, {1}, {2}, {3}", num1, num2, num3, num4);
            Console.WriteLine("A Nullable boolean value: {0}", boolval);
            Console.ReadLine();
            Console.ReadLine();
            */
            /*
            //Null Coalescing Operator (??)
            double? num1 = null;
            double? num2 = 3.14;
            double num3;
            num3 = num1 ?? 5.34;
            Console.WriteLine("Value of num3: {0}", num3);
            num3 = num2 ?? 5.34;
            Console.WriteLine("Value of num3: {0}", num3);
            Console.ReadLine();
            */
            /*
            //array

            int[] n = new int[10];
            int i, j;

            for(i=0; i<10; i++)
            {
                n[i] = i + 100;
            }
            for(j=0; j<10; j++)
            {
                Console.WriteLine("Element[{0}] = {1}", j, n[j]);
            }
            Console.ReadKey();

            // using foreach loop
            int[] a = new int[10];
            for(int b = 0; b < 10; b++)
            {
                a[b] = b + 100;
            }
            foreach(int c in a)
            {
                int b = c - 100;
                Console.WriteLine("Element[{0}] = {1}", b, c);
            }

            Console.ReadKey();
            */

            /*
            //strings
            //string literal and concatenation
            string fname, lname;
            fname = "Aman";
            lname = "Jha";

            char[] letters = { 'H', 'e', 'l', 'l', 'o' };
            string[] saaray = { "Hello", "From", "Aman", "Jha" };

            string fullname = fname + lname;
            Console.WriteLine("Full Name: {0}", fullname);


            //by using string constructor {'h', 'e', 'l', 'l', 'o'}
            string greetings = new string(letters);
            Console.WriteLine("Greetings: {0}", greetings);

            // methods returning string{"Hello", "From", "Aman", "Jha"}
            string message = String.Join(" ", saaray);
            Console.WriteLine("Message:{0}", message);

            //formatting method to convert a value
            DateTime waiting = new DateTime(2021, 10, 11, 23, 12, 1);
            string chat = String.Format("Message sent {0:t} on {0:D}", waiting);
            Console.WriteLine("Message: {0}", chat);

            //comparing strings
            string str1 = "this is Aman Jha";
            string str2 = " this is Bittu";
            if(String.Compare(str1, str2) == 0)
            {
                Console.WriteLine(str1 + "and" + str2 + "are equal.");

            }
            else
            {
                Console.WriteLine(str1 + "and " + str2 + "are not equal.");

            }

            //string contains string
            string str = "This is Aman Jha";
            
            if (str.Contains("Aman"))
            {
                Console.WriteLine("The sequence 'Aman' is found here.");

            }

            //Getting a substring
            string str3 = "Aman Jha is the greatest personality... ";
            Console.WriteLine(str3);
            string substr = str3.Substring(24);
            Console.WriteLine(substr);


            //joining Strings
            string[] starray = new string[] { "I am Aman Jha" };
            string str4 = String.Join("\n", starray);
            Console.WriteLine(str4);

            Console.ReadLine();

            //

            */
            /*
            //Structure 
            Books b1;
            Books b2;

            b1.title = "Principles of Programming Language";
            b1.author = "Aman Jha";
            b1.subject = "Programming Tuitorial";
            b1.book_id = 2345678;

            b2.title = "Concepts of physics";
            b2.author = " H C Verma";
            b2.subject = "physics";
            b2.book_id = 12345;

            Console.WriteLine("Title: {0}", b1.title);
            Console.WriteLine("Author: {0}", b1.author);
            Console.WriteLine("Subject: {0}", b1.subject);
            Console.WriteLine("book_id: {0}", b1.book_id);

            Console.WriteLine("Title: {0}", b2.title);
            Console.WriteLine("Author: {0}", b2.author);
            Console.WriteLine("Subject: {0}", b2.subject);
            Console.WriteLine("book_id: {0}", b2.book_id);

            */
            /*methods in structure
            Books b1 = new Books();
            Books b2 = new Books();
            b1.getValues("Programming Code", "Aman Jha", " Tuitorial", 87934);
            b2.getValues("Physics", "H C Verma", " Tuitorial", 23456789);
            b1.display();
            b2.display();

            Console.ReadKey();
            */
            /*enumeration
            int WeekDayStart = (int)Days.Mon;
            int WeekDayEnd = (int)Days.Fri;

            Console.WriteLine("Monday: {0}", WeekDayStart);
            Console.WriteLine("Friday: {0}", WeekDayEnd);
            Console.ReadKey();
            
            */
            /*
            Box b1 = new Box();
            double volume;
            b1.length = 10.0;
            b1.height = 23.90;
            b1.breadth = 34.8;

            volume = b1.length*b1.height*b1.breadth;
            Console.WriteLine("Volume of Box1: {0}", volume);


            */
            /*
            //member function and encapsulation
            Box b1 = new Box();
            double volume;
            b1.setLength(6.89);
            b1.setHeight(7.98);
            b1.setBreadth(8.98);

            volume = b1.getVolume();
            Console.WriteLine("Volume: {0}", volume);

            //constructor
            Line l = new Line();
            l.setLength(7.0);
            Console.WriteLine("Length of line: {0}", l.getLength());
            Console.ReadKey();

            //parameterized constructor

            Line1 l1 = new Line1(10.0);
            Console.WriteLine("Length of line :{0}", l1.getLength());

            l1.setLength(5.0);
            Console.WriteLine("Length of line : {0}", l1.getLength());
            */
            //destructor
            /*
            Line line = new Line();

            line.setLength(6.0);
            Console.WriteLine("Length of line: {0}", line.getLength());
            */

            /*
            StaticVar s1 = new StaticVar();
            s1.count();
            s1.count();
            s1.count();
            Console.WriteLine(" Variable num of s1: {0}", s1.getNum());
           */

            /*
            Calculator c = new Calculator();
            Console.WriteLine("Addition block");
            Console.WriteLine("Addition answer: {0}", c.addition());
            Console.WriteLine("Subtraction block");
            Console.WriteLine("Subtraction answer: {0}", c.subtraction());
            Console.WriteLine("Multiplication block");
            Console.WriteLine("Multiplication answer: {0}", c.multiplication());
            Console.WriteLine("division block");
            Console.WriteLine("divison answer: {0}", c.division());
            Console.ReadLine();
            */
            /*
            Rectangle r = new Rectangle();
            r.setHeight(7);
            r.setWidth(8);
            Console.WriteLine("Total area: {0}", r.getArea());
            Console.ReadKey();
            */
            /*
            Tabletop t = new Tabletop(4.5, 7.5);
            t.display();
            Console.ReadLine();
        */
            /*
            int num1;
            Console.WriteLine("enter the Month number:");
            num1 = Convert.ToInt32(Console.ReadLine());
            switch (num1)
            {
                case 1:
                    Console.WriteLine("we have 31 days");
                    break;

                case 2:
                    Console.WriteLine("we have 28 days");
                    break;
                case 3:
                    Console.WriteLine("we have 31 days ");
                    break;
                case 4:
                    Console.WriteLine("we have 30 days");
                    break;
                case 5:
                    Console.WriteLine("we have 31 days");
                    break;
                case 6:
                    Console.WriteLine("we have 30 days");
                    break;
                case 7:
                    Console.WriteLine("we have 31 days");
                    break;
                case 8:
                    Console.WriteLine("We have 31 days");
                    break;
                case 9:
                    Console.WriteLine("we have 30 days");
                    break;
                case 10:
                    Console.WriteLine("we have 31 days");
                    break;
                case 11:
                    Console.WriteLine("we have 30 days");
                    break;
                case 12:
                    Console.WriteLine("we have 31 days");
                    break;


            }
            */
            /*
            Employee e = new Employee();
            e.acceptdetails();
            e.getDetails();
            */
            Employee e = new Employee("Aman Kumar Jha", "Software Engineer", 30000, 12345);
            e.EmpDetails();
            Console.ReadKey();
            

             }
    }
}
