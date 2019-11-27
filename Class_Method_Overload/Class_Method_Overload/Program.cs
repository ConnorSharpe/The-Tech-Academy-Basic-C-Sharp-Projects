using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Method_Overload
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math();
            Console.WriteLine("Please enter a whole number: ");
            math.Math1(Convert.ToInt32(Console.ReadLine()));
            Console.ReadLine();

        }
    }
}
