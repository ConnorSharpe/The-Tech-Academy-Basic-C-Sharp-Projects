using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Employee : Person, IQuittable
    {
        public int Id { get; set; }
        public void Quit(Employee employee)
        {
            Console.WriteLine(employee + " quits.");
        }
        public static Employee operator== (Employee employee1, Employee employee2)
        {
            if (employee1.Id != employee2.Id)
            {
                Console.WriteLine("These are two different employees");
            }
            else
            {
                Console.WriteLine("This employee has been entered twice.");
            }
        }
    }
}
