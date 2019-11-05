using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousIncomeComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");

            Console.WriteLine("Person 1");
            Console.WriteLine("What is your hourly rate?");
            string hourlyRate1 = Console.ReadLine();
            float hR1 = float.Parse(hourlyRate1);
            Console.WriteLine("How many hours do you work per week?");
            string workWeek1 = Console.ReadLine();
            float WW1 = float.Parse(workWeek1);

            Console.WriteLine("Person 2");
            Console.WriteLine("What is your hourly rate?");
            string hourlyRate2 = Console.ReadLine();
            float hR2 = float.Parse(hourlyRate2);
            Console.WriteLine("How many hours do you work per week?");
            string workWeek2 = Console.ReadLine();
            float WW2 = float.Parse(workWeek2);

            float weekSalary1 = hR1 * WW1;
            Console.WriteLine("Weekly Salary of Person 1: " + weekSalary1);

            float weekSalary2 = hR2 * WW2;
            Console.WriteLine("Weekly salary of Person 2: " + weekSalary2);

            bool breadMaker = weekSalary1 > weekSalary2;
            Console.WriteLine("Does Person 1 make more money than Person 2? " + breadMaker);

            Console.ReadLine();
        }
    }
}
