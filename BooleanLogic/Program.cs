using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            //USING && FOR AND
            //Console.WriteLine(true && false);
            //Console.WriteLine(true && true);
            //Console.WriteLine(false && false);

            //USING || FOR OR
            //Console.WriteLine(true || false);
            //Console.WriteLine(true || true);
            //Console.WriteLine(false || false);

            //USING == TO COMPARE EQUALITY
            //Console.WriteLine(true == false);
            //Console.WriteLine(true == true);
            //Console.WriteLine(false == false);

            //USING != FOR DOES NOT EQUAL
            //Console.WriteLine(true != false);
            //Console.WriteLine(true != true);
            //Console.WriteLine(false != false);

            //XOR OPERATOR: ^
            //EVALUATES IF ONE IS TRUE BUT NOT BOTH
            //Console.WriteLine(true ^ true);
            //Console.WriteLine(false ^ false);
            //Console.WriteLine(true ^ false);

            Console.WriteLine("How old are you?");
            string Age = Console.ReadLine();
            int age = Convert.ToInt32(Age);

            Console.WriteLine("Have you ever had a DUI? (true or false)");
            string dui = Console.ReadLine();
            bool DUI = Convert.ToBoolean(dui);

            Console.WriteLine("How many speeding tickets have you had?");
            string Tickets = Console.ReadLine();
            int tickets = Convert.ToInt32(Tickets);

            Console.WriteLine("Qualified?");
            bool license = (age > 15) && (DUI == false) && (tickets < 3);
            Console.WriteLine(license);

            Console.ReadLine();
        }
    }
}
