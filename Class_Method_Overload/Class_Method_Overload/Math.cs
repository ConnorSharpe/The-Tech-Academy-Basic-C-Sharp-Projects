using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Method_Overload
{
    class Math
    {
        public void Math1(int num1)
        {
            int num2 = num1 / 2;
            Console.WriteLine(num2);
        }

        public void Math1(int num1, out int num2)
        {
            num2 = num1 / 2;
        }

    }
}
