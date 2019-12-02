using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employee = new Employee<string>() { FirstName = "Sample", LastName = "Student"};
            employee.Things = new List<string>();
            employee.Things.Add("justice");
            employee.Things.Add("Gusto");
            employee.Things.Add("Genitals");

            Employee<int> employee1 = new Employee<int>() { FirstName = "Integer", LastName = "Guy" };
            employee1.Things = new List<int>();
            employee1.Things.Add(1);
            employee1.Things.Add(2);
            employee1.Things.Add(3);
            employee1.Things.Add(4);
            employee1.Things.Add(5);
            employee1.Things.Add(6);


            foreach (string item in employee.Things)
            {
                Console.WriteLine(item);
            }
            foreach (int item in employee1.Things)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
           // IQuittable iQuitable = new Employee<string>() { FirstName = "Connor", LastName = "Sharpe" };
           // iQuitable.Quit(employee);
            Console.ReadLine();
        }
    }
}
