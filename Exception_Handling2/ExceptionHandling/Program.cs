using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter your age!");
                int age = Convert.ToInt32(Console.ReadLine());
                bool validAnswer = false;
                while (!validAnswer)
                {
                    if (age <= 0)
                    {
                        Console.WriteLine("That is literally impossible. Do you take me for a fool? Try again - but for reals.");
                        Console.WriteLine("Please enter your age... AGAIN.");
                        age = Convert.ToInt32(Console.ReadLine());
                    }
                    else
                    {
                        validAnswer = true;
                    }
                }
                int birthYear = 2019 - age;
                Console.WriteLine("You were born in {0}", birthYear);
                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter digits only, no decimals!");
            }
        }
    }
}
