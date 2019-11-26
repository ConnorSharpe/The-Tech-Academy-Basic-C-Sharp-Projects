using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Method
{
    public class Number
    {
            // Create a class. In that class, create three methods, each of which will take one integer parameter in and return an integer.
            // The methods should do some math operation on the received parameter.Put this class in a separate.cs file in the application.
        public int Math1(int num1)
        {
            int result = num1 + 40;
            return result;
        }

        public int Math2(int num2)
        {
            int result2 = num2 * 3;
            return result2;
        }

        public int Math3(int num3)
        {
            int result3 = num3 / 2;
            return result3;
        }
            //2. In the Main() program, ask the user what number they want to do the math operations on.
            //3. Call each method in turn, passing the user input to the method.Display the returned integer to the screen.


    }
}
