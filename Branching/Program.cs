using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching
{
    class Program
    {
        static void Main(string[] args)
        {
            //IF STATEMENTS
            //int currentTemp = 70;
            //int roomTemp = 80;

            //one-line if statement
            //string comparisonResults = currentTemp == roomTemp ? "It is room temp." : "It is not room temp.";
            //Console.WriteLine(comparisonResults);
            //Console.ReadLine();

            //MULTI-LINE STATEMENT
            //if(currentTemp == roomTemp)
            //{
            //    Console.WriteLine("it is exactly room temp!");
            //}
            //else if (currentTemp > roomTemp)
            //{
            //    Console.WriteLine("it is warmer than room temp!");
            //}
            //else if (roomTemp > currentTemp)
            //{
            //    Console.WriteLine("it is colder than room temp!");
            //}
            //else
            //{
            //    Console.WriteLine("it is not exactly room temp");
            //}

            Console.WriteLine("Welcome to Package Express. Please follow the insructions below.");

            Console.WriteLine("What is the package weight?");
            int weight = Convert.ToInt32(Console.ReadLine());
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
            else
            {
                Console.WriteLine("What is the package width?");
                decimal width = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What is the package height?");
                decimal height = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What is the package length?");
                decimal length = Convert.ToInt32(Console.ReadLine());
                decimal dimensions = (width + height + length);
                if ( dimensions > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                }
                else
                {
                    decimal quote = ((dimensions * weight) / 100);
                    string Quote = String.Format("{0:C}", quote);
                    Console.WriteLine("Your estimated total for shipping this package is: " + Quote);
                    Console.WriteLine("Thank you.");
                }
            }
            Console.ReadLine();
        }
    }
}
