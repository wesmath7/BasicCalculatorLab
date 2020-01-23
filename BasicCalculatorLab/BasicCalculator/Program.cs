using System;

namespace BasicCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** BASIC CALCULATOR ***");

            Console.WriteLine("Enter temperature in Fahrenheit");

            // int.Parse will take a string data type and convert it to an int data type
            int firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter relitive humidity");
            int secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter wind speed in mph");
            int ws = int.Parse(Console.ReadLine());


            int sum = 100 - secondNumber;

            double mat = sum * .36;

            double wes = firstNumber - mat;

            Console.WriteLine("The dew point is " + wes);

            double p1 = 0.6215 * firstNumber;

            double result;

            double b = .16;

            result = Math.Pow(ws, b);

            double p2 = 35.75 * result;

            double p3 = .4275 * firstNumber * result;

            double wc = 35.74 + p1 - p2 + p3;

            Console.WriteLine("The wind chill is " + wc);
        }
    }
}


