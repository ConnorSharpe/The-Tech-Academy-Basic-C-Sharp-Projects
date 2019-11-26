using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Method3
{
    class Math
    {
        public int Math1(int num1)
        {
            int result = num1 * 2;
            Console.WriteLine(result);
            return result;
        }
        public int Math1(decimal num1)
        {
            decimal result1 = num1 *3;
            Console.WriteLine(result1);
            return Convert.ToInt32(result1);
        }
        public int Math1(string num1)
        {
            int convert = Convert.ToInt32(num1);
            int result2 = convert * 4;
            Console.WriteLine(result2);
            return result2;
        }
    }
}
