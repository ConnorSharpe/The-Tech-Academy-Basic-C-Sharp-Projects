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
            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student" };
            employee.SayName();
            Console.ReadLine();
            IQuittable iQuitable = new Employee() { FirstName = "Connor", LastName = "Sharpe" };
            iQuitable.Quit(employee);
            Console.ReadLine();
        }
    }
}
