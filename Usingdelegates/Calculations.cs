using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usingdelegates
{
    public class Calculations
    {
        public delegate void calculation(double num1, double num2);


        public static void Add(double num1, double num2)
        {
            Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2));
        }

        public static void Sub(double num1, double num2)
        {
            Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
        }

        public static void Mult(double num1, double num2)
        {
            Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2)); ;
        }

        public static void Div(double num1, double num2)
        {
            if (num2 != 0)
            {
                Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
            }
            else
            {
                Console.WriteLine("Cannot Divide by 0. Please try again");
                
            }
            
        }

    }

    
}
