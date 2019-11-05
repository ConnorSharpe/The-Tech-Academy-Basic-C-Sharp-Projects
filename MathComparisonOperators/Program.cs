using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            //ADDITION
            //int total = 5 + 10;
            //int otherTotal = 12 + 22;
            //int combined = total + otherTotal;
            //Console.WriteLine(combined);
            //Console.ReadLine();


            //SUBTRACTION
            //int difference = 10 - 5;
            //Console.WriteLine(difference);
            //Console.ReadLine();

            //MULTIPLICATION
            //int product = 10 * 5;
            //Console.WriteLine(product);
            //Console.ReadLine();

            //DIVISION
            //int quotient = 100 / 5;
            //Console.WriteLine(quotient);
            //Console.ReadLine();

            //MODULUS '%'
            //int remainder = 5 % 2; //if remainder of %2 is 1, number is odd; if 0, even
            //Console.WriteLine(remainder);
            //Console.ReadLine();

            //COMPARISON OPERATORS:

            //BOOLEANS
            //bool tF = 12 > 5;
            //Console.Write(tF.ToString());
            //Console.ReadLine();

            //int roomTemp = 70;
            //int currentTemp = 72;
            //bool isWarm = currentTemp >= roomTemp; //greater than or equal to
            //Console.WriteLine(isWarm);
            //Console.ReadLine();

            // OPERATORS: <(less than) ,>(greater than) ,=(equal to) ,<= ,>=

            Console.WriteLine("Give me an awesome number to multiply by 50!");
            string times50 = Console.ReadLine();
            long fiftyTimes = Convert.ToInt64(times50);
            long result = fiftyTimes * 50;
            Console.WriteLine("Your number times 50: " + result.ToString());

            Console.WriteLine("Give me an number to add to 25!");
            string Plus25 = Console.ReadLine();
            int plus25 = Convert.ToInt32(Plus25);
            int result1 = plus25 + 25;
            Console.WriteLine("Your number plus 25: " + result1.ToString());

            Console.WriteLine("Give me a number to divide by 12.5!");
            string Divide12 = Console.ReadLine();
            float divide12 = float.Parse(Divide12);
            float result2 = divide12 / 12.5f;
            Console.WriteLine("Your number divided by 12.5: " + result2);

            Console.WriteLine("Give me a number to see if it's greater than 50!");
            string GreaterThan = Console.ReadLine();
            int greaterThan = Convert.ToInt32(GreaterThan);
            bool greaterThan50 = greaterThan > 50;
            Console.WriteLine("Is " + GreaterThan + " greater than 50?: " + greaterThan50);

            Console.WriteLine("Give me a number to find the modulus of x/7!");
            string Mod = Console.ReadLine();
            int modulus = Convert.ToInt32(Mod);
            int mod = modulus % 7;
            Console.WriteLine("The remainder of " + Mod + " / 7 is:" + mod);
            Console.ReadLine();


        }
    }
}
