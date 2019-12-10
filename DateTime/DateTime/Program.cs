using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime nowish = new DateTime();
            nowish = DateTime.Now;
            Console.WriteLine("The time is currently: " + nowish);
            Console.WriteLine("How many hours would you like to wait?: ");
            int wait = Convert.ToInt32(Console.ReadLine());
            DateTime waitTime = new DateTime();
            waitTime = nowish.AddHours(wait);
            Console.WriteLine("By then it will be: " + waitTime);
            Console.ReadLine();
        }
    }
}
