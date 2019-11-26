using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Methods2
{
    class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math();
            math.Math1(30, 15);
            math.Math1(num1: 45, num2: 30);
            Console.ReadLine();
        }
    }
}
