using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Employee<T> : Person
    {
        public List<T> Things { get; set; }
        public int Id { get; set; }
        public void Quit(Employee<T> employee)
        {
            Console.WriteLine(employee + " quits.");
        }
        public static Employee<T> operator== (Employee<T> employee1, Employee<T> employee2)
        {
            if (employee1.Id != employee2.Id)
            {
                Console.WriteLine("These are two different employees");
                return employee1;
            }
            else
            {
                Console.WriteLine("This employee has been entered twice.");
                return employee2;
            }
        }
        public static Employee<T> operator!= (Employee<T> employee1, Employee<T> employee2)
        {
            if (employee1.Id != employee2.Id)
            {
                Console.WriteLine("These are two different employees");
                return employee1;
            }
            else
            {
                Console.WriteLine("This employee has been entered twice.");
                return employee2;
            }
        }

        void Quit(Employee<string> employee) {

            Console.WriteLine("I quit");
        }
            
    }
}
