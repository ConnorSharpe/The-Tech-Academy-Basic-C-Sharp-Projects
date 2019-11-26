using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a class. In that class, create three methods, each of which will take one integer parameter in and return an integer.The methods should do some math operation on the received parameter.Put this class in a separate.cs file in the application.

            // In the Main() program, ask the user what number they want to do the math operations on.
            // Call each method in turn, passing the user input to the method.Display the returned integer to the screen.
            Console.WriteLine("What whole number would you like to perform a buttload of math on?");
            int numb = Convert.ToInt32(Console.ReadLine());

            Number number1 = new Number(); //instantiate object
            Console.WriteLine(number1.Math1(numb));
            Console.WriteLine(number1.Math2(numb));
            Console.WriteLine(number1.Math3(numb));
            Console.ReadLine();

        }
    }

}
