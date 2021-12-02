using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharptuitorial
{
    class Calculator
    {
        public double num1;
        public double num2;
    
  
        public double addition()
        {
            Console.WriteLine("Enter first number:");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            num2 = Convert.ToDouble(Console.ReadLine());
         
            return num1+num2;

        }

        public double subtraction(){
            Console.WriteLine("Enter first number:");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            num2 = Convert.ToDouble(Console.ReadLine());
         

            return num1 - num2;

        }
        public double multiplication()
        {
            Console.WriteLine("Enter first number:");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            num2 = Convert.ToDouble(Console.ReadLine()); 
            return num1 * num2;
        }
        public double division()
        {
            Console.WriteLine("Enter first number:");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            num2 = Convert.ToDouble(Console.ReadLine());
            return num1 / num2;
        }


    }
}
