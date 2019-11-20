using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    class Program
    {
        static void Main(string[] args)
        {
            //try {
            //    Console.WriteLine("Pick a number.");
            //    int numberOne = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Pick another number.");
            //    int numberTwo = Convert.ToInt32(Console.ReadLine());
            //    int numberThree = numberOne / numberTwo;
            //    Console.WriteLine(numberOne + " divided by " + numberTwo + " equals " + numberThree);
            //}
            //catch (FormatException ex)
            //{
            //    Console.WriteLine("Please type a whole number");
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine("You can't divide by zero.");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    Console.ReadLine();
            //}
            //Console.ReadLine();

            List<int> numList = new List<int>();
            numList.Add(12);
            numList.Add(10);
            numList.Add(11);
            numList.Add(9);
            numList.Add(8);

            foreach (int num in numList)
            {
                try
                {
                    Console.WriteLine("Give me a number to divide my numbers by: ");
                    int number = Convert.ToInt32(Console.ReadLine());
                    int solution = num / number;
                    Console.WriteLine("solution accepted!");
                    Console.WriteLine(solution);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("please input an integer.");
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine("You cannot divide by zero.");
                }
            }
            Console.WriteLine("The program has exited the catch/try block!");

            Console.ReadLine();
        }
    }
}
