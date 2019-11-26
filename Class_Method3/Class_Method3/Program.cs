using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Method3
{
    class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math();
            math.Math1(12);

            Math math2 = new Math();
            math2.Math1(1.8m);

            Math math3 = new Math();
            math3.Math1("5");

            Console.ReadLine();
        }
    }
}
