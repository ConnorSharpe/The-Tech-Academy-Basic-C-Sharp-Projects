using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please give me a day of the week");
                string userDay = Console.ReadLine();
                Enum.IsDefined(typeof(DaysOfTheWeek), userDay);
                // Assign the value to a variable of that enum data type you just created.
                Console.ReadLine();
            }
            catch (ArgumentException)
            {
                Console.WriteLine("That is not a day of the week. Please try again!");
            }
            
        }
        public enum DaysOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}
