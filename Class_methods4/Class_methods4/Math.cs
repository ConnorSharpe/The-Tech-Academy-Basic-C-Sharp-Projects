using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_methods4
{
    class Math
    {
        public int Math1(int num1, int num2 = 1)
        {
            int result = num1 + num2;
            Console.WriteLine(result);
            return result;
        }
    }
}
