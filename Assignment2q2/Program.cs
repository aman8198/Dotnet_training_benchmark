using System;

namespace Assignment2q2
{
    enum Day
    {
        SUNDAY, MONDAY, TUESDAY, WEDNESDAY,
        THURSDAY, FRIDAY, SATURDAY
    };
    class Demoenum
    {
        Day day;
        public Demoenum(Day day)
        {
            this.day = day;
        }
        public void Schedule()
        {
            switch (day)
            {
                case Day.MONDAY:
                    Console.WriteLine("C# core Training 9:30 to 11 am");
                    break;
                case Day.TUESDAY:
                    Console.WriteLine("Databases training 8 to 10 am");
                    break;
                case Day.WEDNESDAY:
                    Console.WriteLine("MVC training 10 to 12 pm");
                    break;
                case Day.THURSDAY:
                    Console.WriteLine("ASP.NET CORE training 7 to 11 am");
                    break;
                case Day.FRIDAY:
                    Console.WriteLine(" Project Evaluation 8 to 12 pm");
                    break;
                case Day.SATURDAY:
                    Console.WriteLine("weekly off");
                    break;
                case Day.SUNDAY:
                    Console.WriteLine("week off");
                    break;



            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            Demoenum d = new Demoenum(Day.MONDAY);
            d.Schedule();
            Console.ReadKey();

        }
    }
}
