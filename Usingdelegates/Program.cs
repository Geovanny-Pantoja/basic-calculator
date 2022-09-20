// See https://aka.ms/new-console-template for more information

using System.Data.SqlTypes;
using System.Runtime.InteropServices;
using Usingdelegates;
using static Usingdelegates.Calculations;


class Program
{
    public static void Main(string[] args)
    {
        
        double num1 = 0;
        double num2 = 0;
        calculation add = Calculations.Add;
        calculation sub = Calculations.Sub;
        calculation mult = Calculations.Mult;
        calculation div = Calculations.Div;
        
        Console.WriteLine("Geovanny's Calculator\r");
        Console.Write("----------------------\n");
        Input:
        Console.WriteLine("Please type a number and press enter");
        bool successTryParsenum1 = Double.TryParse(Console.ReadLine(), out num1);

        InputNum2:
        Console.WriteLine("Please enter a second number and press enter");
        bool successTryParsenum2 = Double.TryParse(Console.ReadLine(), out num2);
        Console.Clear();


        if (successTryParsenum1 && successTryParsenum2)
        {

            Console.WriteLine("Choose an option from the following list:");
            Console.WriteLine("\ta - Add");
            Console.WriteLine("\ts - Subtract");
            Console.WriteLine("\tm - Multiply");
            Console.WriteLine("\td - Divide");
            Console.Write("Your option? ");

            
            switch (Console.ReadLine())
            {
                case "a":
                    add(num1, num2);
                    break;
                case "s":
                    sub(num1, num2);
                    break;
                case "m":
                    mult(num1, num2);
                    break;
                case "d":
                    if (num2 != 0)
                    {
                        div(num1, num2);
                    }
                    else
                    {
                        Console.WriteLine("Cannot Divide by 0. Please enter a different number");
                        goto InputNum2;
                    }
                    break;
            }

        }
        else if (!successTryParsenum1 && successTryParsenum2)
        {
            Console.WriteLine("You entered an invalid entry for the first number, Please try again!");
            goto Input;
        }
        else if (!successTryParsenum2 && successTryParsenum1)
        {
            Console.WriteLine("You entered an invalid number for your second number. Please try again");
            goto InputNum2;
        }
        else
        {
            Console.WriteLine("You enter an invalid entry, Please try again!");
            goto Input;
        }


    }

}
